using Android.App;
using Android.Widget;
using Android.OS;
using Ex.Adapters;
using static Android.Resource;
using static Android.Resource.Menu;
using Com.Syncfusion.Carousel;
using System.Collections.Generic;
using Android.Views;
using System;
using Android.Content;

namespace Ex
{
    [Activity(Label = "", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        GridView gridview;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            SetContentView(Resource.Layout.Main);
            gridview = FindViewById<GridView>(Resource.Id.gridview);
            gridview.Adapter = new GridViewAdapter(this);

        }
 

    }
 
}

