using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Xello.Xamarin.Android
{
    [Activity(Label = "Xello.Xamarin.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int clickCounter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button clickMeButton = FindViewById<Button>(Resource.Id.ClickMeButton);

            clickMeButton.Click += (object sender, EventArgs e) =>
            {
                clickCounter++;
                clickMeButton.Text = clickCounter + " clicks!";
            };
        }
    }
}

