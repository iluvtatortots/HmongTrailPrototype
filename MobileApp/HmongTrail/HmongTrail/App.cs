using FreshMvvm;
using HmongTrail.Models;
using HmongTrail.PageModels;
using HmongTrail.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HmongTrail
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var page = FreshPageModelResolver.ResolvePageModel<TitlePageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
