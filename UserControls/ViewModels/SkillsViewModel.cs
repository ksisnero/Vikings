using System;
using System.Windows;
using System.Windows.Threading;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class SkillsViewModel
    {
        private PlayerApi _playerApi;
        private PlayerFile _playerFile;
        public virtual Skills Skills { get; set; }

        public SkillsViewModel()
        {
            _playerApi = new PlayerApi();
            _playerFile = _playerApi.GetPlayerFile();
            if (_playerFile == null) return;

            Skills = _playerFile.Skills;

            BeginAutomaticUpdates();
        }

        private void BeginAutomaticUpdates()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 15);
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        private void Update(object state, EventArgs e)
        {
            _playerFile.Skills = Skills;
            _playerApi.SavePlayerFile(_playerFile);
        }

        private void SkillsUpdated(string skillName, int newValue)
        {
           //convert to list first
        }
    }
}
