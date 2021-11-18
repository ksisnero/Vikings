using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.Helpers
{
    public class XmlFileHelper
    {
        public string SerializePlayerFileToXml(PlayerFile playerFile)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(playerFile.GetType());
            string result = string.Empty;

            using (MemoryStream stream = new MemoryStream())
            {
                xmlSerializer.Serialize(stream, playerFile);
                stream.Position = 0;
                result = new StreamReader(stream).ReadToEnd();
            }
            return result;
        }

        public PlayerFile ReadPlayerFileFromXml(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PlayerFile));
            PlayerFile player;

            using (StreamReader reader = new StreamReader(filePath))
            {
                player = (PlayerFile)xmlSerializer.Deserialize(reader);
            }
            return player;
        }

        public List<Ability> ReadAbilitiesFromXml(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Ability>));
            List<Ability> abilities;

            using (StreamReader reader = new StreamReader(filePath))
            {
                abilities = (List<Ability>)xmlSerializer.Deserialize(reader);
            }
            return abilities;
        }

        public void SaveXmlFile(string xmlString)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlString);

            DirectoryInfo directory = new DirectoryInfo("c:\\Vikings\\");
            if(!directory.Exists)
            {
                directory.Create();
            }

            xmlDocument.Save("c:\\Vikings\\VikingsPlayerFile.xml");
        }
    }
}
