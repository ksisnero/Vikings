using System.ComponentModel;

namespace Vikings.UserControls.Objects
{
    public enum WeaponClass
    {
        [Description("Ultra-light (1)")]
        UltraLight = 1,
        [Description("Light (2)")]
        Light = 2,
        [Description("Medium (4)")]
        Medium = 4,
        [Description("Heavy (6)")]
        Heavy = 6,
        [Description("Ultra-Heavy (8)")]
        UltraHeavy = 8
    }
}
