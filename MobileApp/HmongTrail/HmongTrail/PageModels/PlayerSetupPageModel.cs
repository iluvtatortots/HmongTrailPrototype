using FreshMvvm;
using HmongTrail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HmongTrail.PageModels
{
    public class PlayerSetupPageModel : FreshBasePageModel
    {
        private Game CurrentGame;

        public Command ChooseSoldierCommand
        {
            get
            {
                return new Command(() =>
                {
                    ChooseChar(Enums.CharType.Soldier);
                    CoreMethods.PushPageModel<NamePartyPageModel>(CurrentGame);
                });
            }
        }

        public Command ChooseFarmerCommand
        {
            get
            {
                return new Command(() =>
                {
                    ChooseChar(Enums.CharType.Farmer);
                    CoreMethods.PushPageModel<NamePartyPageModel>(CurrentGame);
                });
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            CurrentGame = initData as Game;
        }

        private void ChooseChar(Enums.CharType charType)
        {
            if (CurrentGame != null)
            {
                CurrentGame.CharacterType = charType;
            }
        }
    }
}
