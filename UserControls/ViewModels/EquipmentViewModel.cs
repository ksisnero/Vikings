using System;
using System.Collections.Generic;
using System.Text;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class EquipmentViewModel
    {
        private PlayerApi _playerApi;
        private PlayerFile _playerFile;
        public List<EquipmentItem> Equipment { get; set; }

        public EquipmentViewModel()
        {
            _playerApi = new PlayerApi();
            _playerFile = _playerApi.GetPlayerFile();
            if (_playerFile == null) return;
        }

        public void PopulateDropdowns()
        {
            var equipment = _playerFile.Equipment;

        }
    }
}
