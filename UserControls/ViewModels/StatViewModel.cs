using System;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class StatViewModel
    {
        private PlayerApi _playerApi;
        private PlayerFile _playerFile;
        public virtual Stats Stats { get; set; }

        public StatViewModel()
        {
            _playerApi = new PlayerApi();
            _playerFile = _playerApi.GetPlayerFile();
            if (_playerFile == null) return;

            Stats = _playerFile.Stats;

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
            _playerFile.Stats = Stats;
            _playerApi.SavePlayerFile(_playerFile);
        }

        private void SkillsUpdated(string skillName, int newValue, int oldValue)
        {
            if (newValue < 0)
            {
                var dialogResult = MessageBox.Show("Are you sure you want to give yourself negative skill points? It will count against you", "Oh no!", MessageBoxButton.YesNo);
                if (dialogResult == MessageBoxResult.Yes)
                {
                    return;
                }
                else
                {
                    newValue = 0;
                }
            } else if (newValue == 0) {
                RecalculateStatPoints();
            } else
            {
                Stats.StatPoints = Stats.StatPoints - newValue;
            }
        }

        private void RecalculateStatPoints()
        {
            var f = 0;
            Stats stat = new Stats();

            PropertyInfo[] properties = typeof(Stats).GetProperties();
            foreach(PropertyInfo property in properties)
            {
                var g = (int)property.GetValue(property);
                f += g;
            }
        }
    }
}
