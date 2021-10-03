using Vikings.UserControls.Helpers;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.MockApi
{
    public class PlayerApi
    {
        public static PlayerFile Player { get; set; }

        public void SavePlayerFile(PlayerFile player)
        {
            var xmlHelper = new XmlFileHelper();
            var xmlString = xmlHelper.SerializePlayerFileToXml(player);
            xmlHelper.SaveXmlFile(xmlString);

            Player = player;
        }

        public PlayerFile GetPlayerFile()
        {
            return Player;
        }
    }
}
