using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vikings.UserControls.MockApi;
using Vikings.UserControls.Objects;

namespace Vikings.UserControls.ViewModels
{
    public class PlayerInformationViewModel
    {
        private PlayerApi _playerApi;
        public virtual Player Player { get; set; }
        public List<State> States { get; set; }

        public PlayerInformationViewModel()
        {
            _playerApi = new PlayerApi();

            GetStates();
        }

        public void Update()
        {
            //every minute? it will save player information and update the xml/json
        }

        public void SaveCurrentPlayer()
        {
            //_playerApi.SavePlayerFile(Player);
        }

        public void ImportPlayer()
        {
            //there will be a button to generate player xml/json
            //this method will import player
        }

        public void GetStates()
        {
            //if (Player == null) return;
            //States = Player.CurrentState;

            States = Enum.GetValues(typeof(State)).Cast<State>().ToList();

            var currentPlayerState = new List<CurrentState>() {
                new CurrentState
                {
                    State = State.Bleeding,
                    StateValue = true
                },
                new CurrentState
                {
                    State = State.Frozen,
                    StateValue = true
                }
            };
        }
    }
}
