﻿using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamBuddyApp.CustomControls;
using XamBuddyApp.Droid.Renderers;

[assembly: ExportRenderer(typeof(LayoutTouchListner), typeof(LayoutTouchListnerRender))]
namespace XamBuddyApp.Droid.Renderers
{
    public partial class LayoutTouchListnerRender : ViewRenderer
    {
        private LayoutTouchListner MainElement;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            MainElement = Element as LayoutTouchListner;
        }

        private static float _start;
        private static float _end;

        public override bool DispatchTouchEvent(MotionEvent e)
        {
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    _start = e.GetY();
                    break;

                case MotionEventActions.Move:

                    _end = e.GetY();
                    float difference = _end - _start;
                    MainElement.DoTouchEvent((difference / 10));
                    break;
            }

            if (MainElement.IsEnebleScroll)
            {
                return base.DispatchTouchEvent(e);
            }
            else
            {
                return true;
            }

        }

        protected override void OnAnimationEnd()
        {
            base.OnAnimationEnd();

            this.LayoutParameters = new LayoutParams(
            Android.Widget.LinearLayout.LayoutParams.FillParent,
            Android.Widget.LinearLayout.LayoutParams.WrapContent);
        }
    }
}