﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MobileAppsFilesSample.Droid
{
    [Activity (Label = "MobileAppsFilesSample.Droid", 
        Icon = "@drawable/icon", 
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        Theme = "@android:style/Theme.Holo.Light")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override async void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            global::Xamarin.Forms.Forms.Init (this, bundle);
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            App.UIContext = this;

            LoadApplication (new App());
        }
    }
}

