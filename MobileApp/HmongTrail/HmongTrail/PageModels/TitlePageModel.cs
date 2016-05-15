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
    public class TitlePageModel : FreshBasePageModel
    {
        public string StartGameText { get { return "Travel the Trail"; } }
        public string BackstoryText { get { return "Learn About the Trail"; } }
        public string CreditsText { get { return "Credits"; } }

        public Command StartGameCommand
        {
            get {
                return new Command(StartGame);
            }
        }

        public Command ShowBackstoryCommand
        {
            get
            {
                return new Command(ShowBackstory);
            }
        }

        public Command ShowCreditsCommand
        {
            get
            {
                return new Command(() => { CoreMethods.PushPageModel<CreditsPageModel>(); });
            }
        }

        public void StartGame()
        {
            CoreMethods.PushPageModel<PlayerSetupPageModel>(new Game());
        }

        public void ShowBackstory()
        {
            CoreMethods.PushPageModel<LearnAboutTheTrailPageModel>();
        }
    }
}
