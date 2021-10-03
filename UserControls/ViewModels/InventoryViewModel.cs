using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Threading;
using Vikings.Implementations;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;
using Vikings.UserControls.Views;

namespace Vikings.UserControls.ViewModels
{
    public class InventoryViewModel : ViewModelBase
    {
        private PlayerApi _playerApi;
        private PlayerFile _playerFile;
        private ICommand _addItemCommand;
        public ObservableCollection<InventoryItem> Inventory { get; set; }
        public ICommand AddItemCommand => _addItemCommand ?? (_addItemCommand = new RelayCommand(AddItem));

        public InventoryViewModel()
        {
            _playerApi = new PlayerApi();
            _playerFile = _playerApi.GetPlayerFile();
            if (_playerFile == null) return;

            Inventory = new ObservableCollection<InventoryItem>();

            RefreshGrid();
            BeginAutomaticUpdates();
        }

        public void AddItem(Object obj)
        {
            var newItemWindow = new InventoryItemWindow();
            var saved = newItemWindow.ShowDialog();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            _playerFile = _playerApi.GetPlayerFile();
            var items = _playerFile.InventoryItems;

            Inventory.Clear();
            foreach(InventoryItem item in items)
            {
                Inventory.Add(item);
            }
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
            List<InventoryItem> items = new List<InventoryItem>(Inventory);

            _playerFile.InventoryItems = items;
            _playerApi.SavePlayerFile(_playerFile);
        }
    }
}
