﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

namespace MyTokyoTrip.Droid
{
    class ActionBarRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);

            RemoveAppIconFromActionBar();
        }

        private void RemoveAppIconFromActionBar()
        {
            var actionBar = ((Activity)Context).ActionBar;
            actionBar.SetIcon(new ColorDrawable(Color.Transparent.ToAndroid()));
        }
    }
}