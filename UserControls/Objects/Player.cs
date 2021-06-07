using System.Collections.Generic;

namespace Vikings.UserControls.Objects
{
    public class Player
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int AbilityLevel { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public int GoldPieces { get; set; }
        public int ClanRank { get; set; }
        public int ClanPoints { get; set; }
        public int XP { get; set; }
        public int Sanity { get; set; }
        public List<CurrentState> CurrentState { get; set; }
        public List<bool> SpecialItemSlots { get; set; }
    }
}
