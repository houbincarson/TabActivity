using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GuangDongGold
{
    [Activity(Label = "GuangDongGold", MainLauncher = true, Icon = "@drawable/icon")]
    public class HomeActivity : TabActivity
    { 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.layout_Home);
            Initialize();
        }

        private void Initialize()
        {
            TabHost.TabSpec spec;     
            Intent intent;            // 嘻嘻嘻嘻嘻嘻

            View TabIcon1 = (View)LayoutInflater.From(this).Inflate(Resource.Layout.TabIcon1, null);
            View TabIcon2 = (View)LayoutInflater.From(this).Inflate(Resource.Layout.TabIcon2, null);
            View TabIcon3 = (View)LayoutInflater.From(this).Inflate(Resource.Layout.TabIcon3, null);
            View TabIcon4 = (View)LayoutInflater.From(this).Inflate(Resource.Layout.TabIcon4, null);
            View TabIcon5 = (View)LayoutInflater.From(this).Inflate(Resource.Layout.TabIcon5, null);

            //Display Windows = WindowManager.DefaultDisplay;
            //RelativeLayout Tabs = FindViewById<RelativeLayout>(Resource.Id.asb);
            //Tabs.LayoutParameters.Height = 100;
            //Tabs.LayoutParameters.Height = Convert.ToInt16(Windows.Width * 0.15);

            intent = new Intent(this, typeof(Activity1));
            intent.AddFlags(ActivityFlags.NewTask);
            spec = TabHost.NewTabSpec("tab1");
            spec.SetIndicator(TabIcon1);
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(Activity2));
            intent.AddFlags(ActivityFlags.NewTask);
            spec = TabHost.NewTabSpec("tab2");
            spec.SetIndicator(TabIcon2);
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(Activity3));
            intent.AddFlags(ActivityFlags.NewTask);
            spec = TabHost.NewTabSpec("tab3");
            spec.SetIndicator(TabIcon3);
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(Activity4));
            intent.AddFlags(ActivityFlags.NewTask);
            spec = TabHost.NewTabSpec("tab4");
            spec.SetIndicator(TabIcon4);
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(Activity5));
            intent.AddFlags(ActivityFlags.NewTask);
            spec = TabHost.NewTabSpec("tab5");
            spec.SetIndicator(TabIcon5);
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            TabHost.CurrentTab = 0;
        }
    }
}

