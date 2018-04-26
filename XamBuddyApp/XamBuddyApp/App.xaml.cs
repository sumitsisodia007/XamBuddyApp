using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamBuddyApp.View;
using XamBuddyApp.ViewModels;

namespace XamBuddyApp
{
    public partial class App : Application
    {
        public App()
        {
            try
            {
                InitializeComponent();
                MainPage =new NavigationPage( new AddYouTube());
            }
            catch (Exception ex)
            {
            }//MainPage = new XamBuddyApp.MainPage();
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
