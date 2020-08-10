using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PropertyApp.Droid;
using System.Net;
using System.Net.Security;

namespace TravelApp.Droid
{
    [Activity(Label = "TravelApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicy) =>
            {
                if (sslPolicy == SslPolicyErrors.None)
                    return true;

                if (sslPolicy == SslPolicyErrors.RemoteCertificateChainErrors &&
                   ((HttpWebRequest)sender).RequestUri.AbsoluteUri.Equals("a trusted URL"))
                    return true;

                return false;
            };

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}