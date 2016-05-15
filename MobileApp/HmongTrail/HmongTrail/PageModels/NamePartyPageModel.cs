using FreshMvvm;
using HmongTrail.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HmongTrail.PageModels
{
    [ImplementPropertyChanged]
    public class NamePartyPageModel : FreshBasePageModel
    {
        private Game CurrentGame { get; set; }
        private Character Char1 { get { return CurrentGame.Party[0]; } }
        private Character Char2 { get { return CurrentGame.Party[1]; } }
        private Character Char3 { get { return CurrentGame.Party[2]; } }
        private Character Char4 { get { return CurrentGame.Party[3]; } }

        public string Char1Name {
            get { return Char1.Name; }
            set {
                if (value != Char1Name)
                {
                    Char1.Name = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Char2Name
        {
            get { return Char2.Name; }
            set
            {
                if (value != Char2Name)
                {
                    Char2.Name = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Char3Name
        {
            get { return Char3.Name; }
            set
            {
                if (value != Char3Name)
                {
                    Char3.Name = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Char4Name
        {
            get { return Char4.Name; }
            set
            {
                if (value != Char4Name)
                {
                    Char4.Name = value;
                    RaisePropertyChanged();
                }
            }
        }

        public Command ContinueCommand {
            get {
                return new Command(() => {
                    CoreMethods.DisplayAlert("Continue", "Continue", "OK");
                    //CoreMethods.PushPageModel<>(CurrentGame);
                });
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            CurrentGame = initData as Game;
        }
    }
}
