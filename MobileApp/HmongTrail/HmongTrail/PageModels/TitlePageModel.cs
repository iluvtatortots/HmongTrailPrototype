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
    public class TitlePageModel : FreshBasePageModel
    {
        public Command StartGameCommand
        {
            get {
                return new Command(StartGame);
            }
        }

        public void StartGame()
        {
            CoreMethods.PushPageModel<PlayerSetupPageModel>(new Game());
        }
    }
}
