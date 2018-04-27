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
        public static int ScreenWidth;
        public static int ScreenHeight;
        public App()
        {
            try
            {
                InitializeComponent();
                if (ScreenHeight == 0)
                    ScreenHeight = 1000;
                if (ScreenWidth == 0)
                    ScreenWidth = 600;
                MainPage =new NavigationPage( new MainPage());
                //MainPage = new XFMasterDetailPage();//new NavigationPage( new AddYouTube());
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
