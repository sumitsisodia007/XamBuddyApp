using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamBuddyApp.Models;
using XamBuddyApp.TabViews;

namespace XamBuddyApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XFMasterDetailPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public XFMasterDetailPage ()
		{   
			InitializeComponent ();
            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Custom Loader", Icon = "icon.png", TargetType = typeof(CustomLoaderTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Popup Page", Icon = "icon.png", TargetType = typeof(CustomPopupTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms (Dynamic) MDP", Icon = "icon.png", TargetType = typeof(DynamicMDP) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin Forms ReturnType Key ", Icon = "icon.png", TargetType = typeof(ReturnTypeTabPage) });
            //menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Blurred Image", Icon = "icon.png", TargetType = typeof(HomePage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Custom Switch Button", Icon = "icon.png", TargetType = typeof(CustomSwitchButtonTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Custom Slider", Icon = "icon.png", TargetType = typeof(CustomSliderTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Curved Entry", Icon = "icon.png", TargetType = typeof(CustomEntryTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Custom Label", Icon = "icon.png", TargetType = typeof(CustomLabelTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Slider Lock", Icon = "icon.png", TargetType = typeof(SliderLockTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Custom Button", Icon = "icon.png", TargetType = typeof(CustomButtonTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Custom Underline ", Icon = "icon.png", TargetType = typeof(UnderLineTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Custom Image Entry", Icon = "icon.png", TargetType = typeof(ImageEntryTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Animation With Triggers", Icon = "icon.png", TargetType = typeof(AnimTriggerTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms Animation", Icon = "icon.png", TargetType = typeof(AnimationTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin Forms Lottie Animations", Icon = "icon.png", TargetType = typeof(LottieAnimTabPage) });
            menuList.Add(new MasterPageItem() { Title = "Xamarin.Forms FAB Button", Icon = "icon.png", TargetType = typeof(FABTabPage) });
            
            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)));
        }
        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}