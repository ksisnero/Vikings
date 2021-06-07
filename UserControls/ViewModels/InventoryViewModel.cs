using System.Collections.Generic;
using System.Windows.Input;
using Vikings.Implementations;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;
using Vikings.UserControls.Views;

namespace Vikings.UserControls.ViewModels
{
    public class InventoryViewModel : ViewModelBase
    {
        private InventoryApi _inventoryApi;
        public List<InventoryItem> Inventory { get; set; }

        public InventoryViewModel()
        {
            _inventoryApi = new InventoryApi();
            RefreshGrid();
        }

        public void AddItem()
        {
            var newItemWindow = new InventoryItemWindow();
            var closed = newItemWindow.ShowDialog();

            if((bool)closed)
            {
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            Inventory = _inventoryApi.GetInventory();
        }
    }
}
