using System.Collections.Generic;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.Database
{
    public class AbilityApi
    {
        public List<Ability> getAbilities()
        {
            return new List<Ability>()
            {
                new Ability
                {
                    AbilityName = "Suture",
                    AbilityDescription = "+50 Heal Thyself",
                    AbilityRange = 0,
                    RequiredLevel = 0,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Mend",
                    AbilityDescription = "+50 Heal Other",
                    AbilityRange = 1,
                    RequiredLevel = 0,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Cure",
                    AbilityDescription = "Cure Poison",
                    AbilityRange = 1,
                    RequiredLevel = 0,
                    RequiredMinimalEnergy = 100
                },
                new Ability
                {
                    AbilityName = "Ward",
                    AbilityDescription = "(reactive) Block Incoming Ability",
                    AbilityRange = 1,
                    RequiredLevel = 0,
                    RequiredMinimalEnergy = 100
                },
                new Ability
                {
                    AbilityName = "Ember",
                    AbilityDescription = "+50 Burn",
                    AbilityRange = 2,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Chilling Wind",
                    AbilityDescription = "+50 Freeze",
                    AbilityRange = 2,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Intense Light",
                    AbilityDescription = "+50 Paralyze",
                    AbilityRange = 2,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Cut",
                    AbilityDescription = "+50 Bleeding",
                    AbilityRange = 2,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Alchemy",
                    AbilityDescription = "Item -> 1 GP",
                    AbilityRange = 0,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 100
                },
                new Ability
                {
                    AbilityName = "ShieldMaiden",
                    AbilityDescription = "(Reactive) Block ability heading tword ally",
                    AbilityRange = 2,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 100
                },
                new Ability
                {
                    AbilityName = "Illuminate",
                    AbilityDescription = "Create Light Orb in Hand",
                    AbilityRange = 0,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 100
                },
                new Ability
                {
                    AbilityName = "Reinforce",
                    AbilityDescription = "Tame Animal (2 Spaces)",
                    AbilityRange = 2,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 100
                },
                new Ability
                {
                    AbilityName = "Fear",
                    AbilityDescription = "Cause target to run 2 spaces",
                    AbilityRange = 3,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 100
                },
            };
        }

        public List<Ability> getLearnedAbilities()
        {
            return new List<Ability>()
            {
                new Ability
                {
                    AbilityName = "Vanish",
                    AbilityDescription = "Vanish into thin air (one turn)",
                    AbilityRange = 0,
                    RequiredLevel = 0,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Spectral Wall",
                    AbilityDescription = "Create a 3x1 energy wall in front of you",
                    AbilityRange = 1,
                    RequiredLevel = 0,
                    RequiredMinimalEnergy = 50
                },
                new Ability
                {
                    AbilityName = "Mind Shatter",
                    AbilityDescription = "block an enemy from using an ability",
                    AbilityRange = 2,
                    RequiredLevel = 1,
                    RequiredMinimalEnergy = 100
                },
            };
        }
    }
}
