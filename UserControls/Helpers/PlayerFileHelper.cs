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
                var playerFile = xmlHelper.ReadPlayerFileFromXml(filePath);

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
            var player = ReturnNewPlayerFile();
            var playerApi = new PlayerApi();
            playerApi.SavePlayerFile(player);

            return true;
        }

        private PlayerFile ReturnNewPlayerFile()
        {
            return new PlayerFile()
            {
                Abilities = new List<Ability>(),
                Armor = new List<Armor>(),
                Equipment = new List<EquipmentItem>(),
                InventoryItems = new List<InventoryItem>(),
                LearnedAbilities = new List<Ability>(),
                Player = new Player(),
                Skills = new Skills()
                {
                    Acrobatics = new Skill
                    {
                        SkillName = "Acrobatics",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    AnimalCare = new Skill
                    {
                        SkillName = "AnimalCare",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Atheltics = new Skill
                    {
                        SkillName = "Atheltics",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Clan = new Skill
                    {
                        SkillName = "Clan",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Deception = new Skill
                    {
                        SkillName = "Deception",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Dueling = new Skill
                    {
                        SkillName = "Dueling",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    FirstAid = new Skill
                    {
                        SkillName = "FirstAid",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    History = new Skill
                    {
                        SkillName = "History",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Intimidation = new Skill
                    {
                        SkillName = "Intimidation",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Investigation = new Skill
                    {
                        SkillName = "Investigation",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Medicine = new Skill
                    {
                        SkillName = "Medicine",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    MusicalTalent = new Skill
                    {
                        SkillName = "MusicalTalent",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Nature = new Skill
                    {
                        SkillName = "Nature",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Persuasion = new Skill
                    {
                        SkillName = "Persuasion",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    SleightOfHand = new Skill
                    {
                        SkillName = "SleightOfHand",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Stealth = new Skill
                    {
                        SkillName = "Stealth",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    Survival = new Skill
                    {
                        SkillName = "Survival",
                        BaseSkillPoints = 0,
                        SkillModifications = 0,
                        TotalSkillPoints = 0
                    },
                    SpendableSkillPoints = 10
                },
                Stats = new Stats()
                {
                    Appearance = new Stat
                    {
                        BaseStatPoints = 0,
                        StatModifications = 0,
                        StatName = "Appearance",
                        TotalStatPoints = 0
                    },
                    Charisma = new Stat
                    {
                        BaseStatPoints = 0,
                        StatModifications = 0,
                        StatName = "Charisma",
                        TotalStatPoints = 0
                    },
                    Constitution = new Stat
                    {
                        BaseStatPoints = 0,
                        StatModifications = 0,
                        StatName = "Constitution",
                        TotalStatPoints = 0
                    },
                    Dexerity = new Stat
                    {
                        BaseStatPoints = 0,
                        StatModifications = 0,
                        StatName = "Dexerity",
                        TotalStatPoints = 0
                    },
                    Intellegence = new Stat
                    {
                        BaseStatPoints = 0,
                        StatModifications = 0,
                        StatName = "Intellegence",
                        TotalStatPoints = 0
                    },
                    Perception = new Stat
                    {
                        BaseStatPoints = 0,
                        StatModifications = 0,
                        StatName = "Perception",
                        TotalStatPoints = 0
                    },
                    Strength = new Stat
                    {
                        BaseStatPoints = 0,
                        StatModifications = 0,
                        StatName = "Strength",
                        TotalStatPoints = 0
                    },
                    StatPoints = 0
                },
                Weapons = new List<Weapon>()
            };
        }
    }
}
