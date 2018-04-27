﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamBuddyApp.ListViewAnim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            InfoList.ItemsSource = GetItems();

            MenuGrid.HeightRequest = App.ScreenHeight * 0.1;
            Head.HeightRequest = App.ScreenHeight * 0.1;
            Body.HeightRequest = App.ScreenHeight * 0.9;

            Title = "3 - Full animation (apper/dissap first element)";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            PrepareAnimate();
        }



        #region MoveImg

        /// <summary>
        /// Fly Image on Header
        /// </summary>
        private async void FlyImg()
        {
            var rdm = new Random();
            do
            {
                var w = rdm.Next(1, 100);
                var h = rdm.Next(1, 100);
                await MainImage.TranslateTo(w, h, 5000, Easing.Linear);
                await Task.Delay(1000);
            } while (true);
        }

        #endregion

        #region MoveList

        private bool IsUpper = false;

        /// <summary>
        /// First item Appearing => animate MoveDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPageViewCellWithId_OnFirstApper(object sender, EventArgs e)
        {
            IsUpper = true;
            MoveDown();
        }

        /// <summary>
        /// First item Disappearing => animate MoveUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPageViewCellWithId_OnFirstDisapp(object sender, EventArgs e)
        {
            IsUpper = false;
            MoveUp();
        }

        private void MoveDown()
        {
            Body.TranslateTo(0, 200, 500, Easing.Linear);
            MenuGrid.TranslateTo(0, 100, 500, Easing.Linear);
            TitleLabel.ScaleTo(2, 500, Easing.Linear);
            ico.ScaleTo(1.5, 500, Easing.Linear);
        }

        private void MoveUp()
        {
            Body.TranslateTo(0, 0, 500, Easing.Linear);
            MenuGrid.TranslateTo(0, 0, 500, Easing.Linear);
            TitleLabel.ScaleTo(1, 500, Easing.Linear);
            ico.ScaleTo(1, 500, Easing.Linear);
        }


        private async void PrepareAnimate()
        {
            await MainImage.ScaleTo(3, 500, Easing.Linear);
            await Body.TranslateTo(0, 200, 50, Easing.Linear);
            await MenuGrid.TranslateTo(0, 100, 50, Easing.Linear);
            await TitleLabel.ScaleTo(2, 50, Easing.Linear);
            await ico.ScaleTo(1.5, 50, Easing.Linear);

            FlyImg();
        }

        #endregion



        /// <summary>
        /// Fake items for listView
        /// </summary>
        /// <returns></returns>
        private List<Item> GetItems()
        {
            var list = new List<Item>();

            for (int i = 1; i < 20; i++)
            {
                list.Add(new Item("item " + i, i));
            }
            return list;
        }
    }
}