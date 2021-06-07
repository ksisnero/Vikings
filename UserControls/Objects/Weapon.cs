using System.Collections.Generic;

namespace Vikings.UserControls.Objects
{
    public class Weapon
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int DamageBoost { get; set; }
        public int EnergyCost { get; set; }
        public int Range { get; set; }
        public bool OneHanded { get; set; }
        public bool SpecialItem { get; set; }
        public WeaponClass WeaponClass { get; set; }
        public List<Effect> Effects { get; set; }
    }
}
