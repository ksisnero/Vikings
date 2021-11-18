using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Vikings.Implementations;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class NewInventoryItemViewModel
    {
        private PlayerApi _playerApi;
        private PlayerFile _playerFile;
        private ICommand _saveCommand;
        public Action CloseAction { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string Notes { get; set; }
        public bool isArmor { get; set; }
        public bool isWeapon { get; set; }
        public EquipmentItem Equipment { get; set; }
        public ObservableCollection<Effect> ArmorEffects { get; set; }
        public ObservableCollection<Effect> WeaponEffects { get; set; }
        public ICommand SaveCommand => _saveCommand ?? (_saveCommand = new RelayCommand(SaveToInventory));

        public NewInventoryItemViewModel()
        {
            _playerApi = new PlayerApi();
            _playerFile = _playerApi.GetPlayerFile();
            if (_playerFile == null) return;

            ArmorEffects = new ObservableCollection<Effect>();
            WeaponEffects = new ObservableCollection<Effect>();
        }

        public void AddArmorEffect()
        {

        }

        public void AddWeaponEffect()
        {

        }

        public void SaveToInventory(Object obj)
        {
            var fieldsAreValid = ValidateFields();
            if(fieldsAreValid)
            {
                _playerFile.InventoryItems.Add(new InventoryItem
                {
                    ItemName = ItemName,
                    Notes = Notes,
                    Quantity = Quantity
                });
                _playerApi.SavePlayerFile(_playerFile);
                CloseAction();
            }
        }

        private bool ValidateFields()
        {
            if(string.IsNullOrEmpty(ItemName.Trim()))
            {
                MessageBox.Show("Item name cannot be empty", "Oof", MessageBoxButton.OK);
                return false;
            } 
            else if(string.IsNullOrEmpty(Quantity.Trim()))
            {
                MessageBox.Show("Item quantity cannot be empty", "Oof", MessageBoxButton.OK);
                return false;
            }
            return true;
        }

        private void RefreshArmorGrid()
        {
            _playerFile = _playerApi.GetPlayerFile();
            ArmorEffects.Clear();

            foreach (Armor armor in _playerFile.Armor)
            {
                foreach(Effect effect in armor.Effects)
                {
                    ArmorEffects.Add(effect);
                }
            }
        }

        private void RefreshWeaponGrid()
        {
            _playerFile = _playerApi.GetPlayerFile();
            WeaponEffects.Clear();

            foreach (Weapon weapon in _playerFile.Weapons)
            {
                foreach (Effect effect in weapon.Effects)
                {
                    ArmorEffects.Add(effect);
                }
            }
        }

    }
}
