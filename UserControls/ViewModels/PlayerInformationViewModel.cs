using System;
using System.Windows.Threading;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class PlayerInformationViewModel
    {
        private PlayerApi _playerApi;
        private PlayerFile _playerFile;
        public virtual Player Player { get; set; }

        public PlayerInformationViewModel()
        {
            _playerApi = new PlayerApi();
            _playerFile = _playerApi.GetPlayerFile();
            if (_playerFile == null) return;

            Player = _playerFile.Player;

            DispatcherTimer timer = new DispatcherTimer();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 15);
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        private void Update(object state, EventArgs e)
        {
            _playerFile.Player = Player;
            _playerApi.SavePlayerFile(_playerFile);
        }
    }
}
