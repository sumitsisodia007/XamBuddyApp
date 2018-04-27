using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamBuddyApp.ListViewAnim;
using XamBuddyApp.TabViews;
using XamBuddyApp.View;

namespace XamBuddyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnimationTabPage());
        }

        private void btnList1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void btnList2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void btnList3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void btnList4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }

        private void btnListArt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ArticleLiatPage());
        }
    }
}
