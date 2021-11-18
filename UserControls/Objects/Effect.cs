using System.Collections.Generic;

namespace Vikings.UserControls.Objects
{
    public class Effect
    {
        public List<Skill> SkillEffect { get; set; }            // only edit skill name and modification 
        public List<Stat> StatEffect { get; set; }              // only edit stat name and modification 
        public int EnergyEffect { get; set; }
        public int HealthEffect { get; set; }
    }
}
