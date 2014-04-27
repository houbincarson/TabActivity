using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GuangDongGold
{
    [Activity(Label = "My Activity")]
    public class Activity3 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle); 
            SetContentView(Resource.Layout.layout_Page);
            TextView tv = this.FindViewById<TextView>(Resource.Id.textView1);
            tv.Text = "Activity3";
        }
    }
}