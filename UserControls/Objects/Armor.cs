using System.Collections.Generic;

namespace Vikings.UserControls.Objects
{
    public class Armor
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string RequirementsDescription { get; set; }
        public int ArmorSet { get; set; }
        public int ArmorSetTotal { get; set; }
        public bool SpecialItem { get; set; }
        public List<Effect> Effects { get; set; }
        public List<Effect> SetCompletionBonus { get; set; }
        public ArmorClass ArmorClass { get; set; }

    }
}
