using System.ComponentModel;

namespace Vikings.UserControls.Objects
{
    public enum ArmorClass
    {
        [Description("Ultra-light (1)")]
        UltraLight = 1,
        [Description("Light (2)")]
        Light = 2,
        [Description("Medium (3)")]
        Medium = 3,
        [Description("Heavy (4)")]
        Heavy = 4,
        [Description("Ultra-Heavy (5)")]
        UltraHeavy = 5
    }
}
