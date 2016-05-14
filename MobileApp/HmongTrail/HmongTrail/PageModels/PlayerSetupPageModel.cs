using FreshMvvm;
using HmongTrail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HmongTrail.PageModels
{
    public class PlayerSetupPageModel : FreshBasePageModel
    {
        //public Command ChooseSoldierCommand
        //{

        //}

        //public Command ChooseFarmerCOmmand
        //{
        //    get
        //    {

        //    }
        //}


        public override void Init(object initData)
        {
            base.Init(initData);

            Game game = initData as Game;

            var x = 5;
        }
    }
}
