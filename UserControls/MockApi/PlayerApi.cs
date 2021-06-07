using Vikings.UserControls.Objects;

namespace Vikings.UserControls.MockApi
{
    public class PlayerApi
    {
        public static PlayerFile Player { get; set; }

        public void SavePlayerFile(PlayerFile player)
        {
            Player = player;
        }

        public PlayerFile GetPlayerFile()
        {
            return Player;
        }
    }
}
