using System;
using System.Collections.Generic;

namespace Vikings.UserControls.Objects
{
    public class Skills
    {
        public Skill Acrobatics { get; set; }
        public Skill AnimalCare { get; set; }
        public Skill Dueling { get; set; }
        public Skill Atheltics { get; set; }
        public Skill Clan { get; set; }
        public Skill Deception { get; set; }
        public Skill History { get; set; }
        public Skill Intimidation { get; set; }
        public Skill Investigation { get; set; }
        public Skill Medicine { get; set; }
        public Skill Nature { get; set; }
        public Skill MusicalTalent { get; set; }
        public Skill Persuasion { get; set; }
        public Skill Survival { get; set; }
        public Skill Stealth { get; set; }
        public Skill SleightOfHand { get; set; }
        public Skill FirstAid { get; set; }
        public int SpendableSkillPoints { get; set; }

        public static implicit operator List<object>(Skills v)
        {
            throw new NotImplementedException();
        }
    }
}
