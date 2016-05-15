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
    public class CurrentStatusBadPageModel : FreshBasePageModel
    {
        public Command ContinueTravelingCommand
        {
            get
            {
                return new Command(() => {
                    CoreMethods.PushPageModel<YouMadeItPageModel>();
                });
            }
        }
    }
}
