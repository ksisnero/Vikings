using System.Collections.Generic;

namespace Vikings.UserControls.Objects
{
    public class PlayerFile
    {
        public Player Player { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Ability> LearnedAbilities { get; set; }
        public Skills Skills { get; set; }
        public Stats Stats { get; set; }
        public List<InventoryItem> InventoryItems { get; set; }
        public List<EquipmentItem> Equipment { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Armor> Armor { get; set; }
    }
}
