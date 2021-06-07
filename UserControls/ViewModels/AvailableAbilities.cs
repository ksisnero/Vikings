using System.Collections.Generic;
using System.Linq;
using Vikings.UserControls.Database;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class AvailableAbilities
    {
        public virtual List<Ability> Abilities { get; set; }
        public AvailableAbilities()
        {
            Abilities = CalculateAvailableAbilities();
        }

        public List<Ability> CalculateAvailableAbilities()
        {
            var abilityApi = new AbilityApi();
            var playerApi = new PlayerApi(); 

            var currentPlayer = playerApi.GetPlayerFile();
            var abilityList = abilityApi.getAbilities();

            if (currentPlayer == null) return null;
            if (!abilityList.Any()) return null;

            var abilities = new List<Ability>();
            abilities.AddRange(abilityList);
            //abilities = abilities.Where(x => x.RequiredLevel == currentPlayer.AbilityLevel).ToList();
            //abilities = abilities.Where(x => x.RequiredMinimalEnergy <= currentPlayer.Energy).ToList();

            return abilities;
        }
    }
}
