using System;
using System.Collections.Generic;
using System.Text;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.MockApi
{
    public class InventoryApi
    {
        public List<InventoryItem> GetInventory()
        {
            //read player json
            return null;
        }

        public void SaveInventoryItem(InventoryItem item)
        {
            //add on to the json
        }

        public void DeleteInventoryItem(InventoryItem item)
        {
            //remove from the json
            //ideally delete the whole thing and redo it, maybe?
        }
    }
}
