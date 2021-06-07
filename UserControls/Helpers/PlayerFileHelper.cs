using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;
using Vikings.UserControls.Helpers;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls
{
    public class PlayerFileHelper
    {
        public Player Player { get; set; }

        public bool OpenPlayerFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\Vikings\\";
            fileDialog.Filter = "XML Files (*.xml)|*.xml";

            var dialogSuccess = fileDialog.ShowDialog() ?? false;

            if (dialogSuccess)
            {
                var filePath = fileDialog.FileName;

                var xmlHelper = new XmlFileHelper();
                var playerFile = xmlHelper.ReadFromXml(filePath);

                if (playerFile == null)
                {
                    MessageBox.Show("Error occured when getting PlayerInfo", "Oh no!", MessageBoxButton.OK);
                    return false;
                }

                var playerApi = new PlayerApi();
                playerApi.SavePlayerFile(playerFile);
                return true;
            }
            return false;
        }

        public bool CreateNewPlayerFile()
        {
            var player = new PlayerFile()
            {
                Abilities = new List<Ability>(),
                Armor = new List<Armor>(),
                Equipment = new List<EquipmentItem>(),
                InventoyItems = new List<InventoryItem>(),
                LearnedAbilities = new List<Ability>(),
                Player = new Player(),
                Skills = new List<Skill>(),
                Stats = new List<Stat>(),
                Weapons = new List<Weapon>()
            };
            var xmlHelper = new XmlFileHelper();
            var xmlString = xmlHelper.SerializeToXml(player);
            xmlHelper.SaveXmlFile(xmlString);

            return true;
        }
    }
}
