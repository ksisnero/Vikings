using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Vikings.Implementations;
using Vikings.UserControls.Helpers;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class AvailableAbilitiesViewModel
    {
        private PlayerApi _playerApi;
        private PlayerFile _playerFile;
        private ICommand _addAbilityFileCommand;
        public ObservableCollection<Ability> Abilities { get; set; }
        public ICommand AddAbilityFileCommand => _addAbilityFileCommand ?? (_addAbilityFileCommand = new RelayCommand(AddAbilityFile));

        public AvailableAbilitiesViewModel()
        {
            _playerApi = new PlayerApi();
            _playerFile = _playerApi.GetPlayerFile();
            if (_playerFile == null) return;

            Abilities = new ObservableCollection<Ability>();
            foreach (Ability ability in _playerFile.Abilities)
            {
                Abilities.Add(ability);
            }

            CalculateAvailableAbilities();
        }

        public void CalculateAvailableAbilities()
        {
            if(Abilities.Any())
            {
                if (!Abilities.Any()) return;

                var currentPlayer = _playerFile.Player;
                Abilities.Where(x => x.RequiredLevel <= currentPlayer.AbilityLevel);
                Abilities.Where(x => x.RequiredMinimalEnergy <= currentPlayer.Energy);
                Abilities.OrderBy(x => x.RequiredLevel);
            }
        }

        public void AddAbilityFile(object obj)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\Vikings\\";
            fileDialog.Filter = "XML Files (*.xml)|*.xml";

            var dialogSuccess = fileDialog.ShowDialog() ?? false;

            if (dialogSuccess)
            {
                var filePath = fileDialog.FileName;

                var xmlHelper = new XmlFileHelper();
                var abilities = xmlHelper.ReadAbilitiesFromXml(filePath);

                if (abilities == null)
                {
                    MessageBox.Show("Error occured when getting ability file", "Oh no!", MessageBoxButton.OK);
                }

                if(Abilities != null)
                {
                    Abilities.Clear();
                    foreach (Ability ability in abilities)
                    {
                        Abilities.Add(ability);
                    }

                    _playerFile.Abilities = abilities;
                    CalculateAvailableAbilities();

                    _playerApi.SavePlayerFile(_playerFile);
                }
            }
        }
    }
}
