using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Rbddevs.Splashy;

namespace XamarinSplashyJavaLibraryBinding
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Splashy splashy = new Splashy(this);
            splashy
              .SetLogo(Resource.Drawable.splashy)
              .SetAnimation(Splashy.Animation.GrowLogoFromCenter, 800)
              .SetBackgroundResource(Resource.Color.black)
              .SetTitleColor(Resource.Color.white)
              .SetProgressColor(Resource.Color.white)
              .SetTitle(Resource.String.splashy)
              .SetSubTitle(Resource.String.splash_screen_made_easy)
              .SetFullScreen(true)
              .SetClickToHide(true)
              //.setInfiniteDuration(true)
              .SetTime(5000)
              .Show();

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

