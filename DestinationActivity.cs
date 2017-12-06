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

namespace BlogApp
{
    [Activity(Label = "DestinationActivity")]
    public class DestinationActivity : Activity
    {
        ListView listView;
        List<CityClass> cc = new List<CityClass>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.destinationLayout);
            // Create your application here
            listView = FindViewById<ListView>(Resource.Id.listView1);
            CityClass c1 = new CityClass("Venice", Resource.Drawable.venice2);
            CityClass c2 = new CityClass("Berlin", Resource.Drawable.berlin2);
            CityClass c3 = new CityClass("Tokyo", Resource.Drawable.tokyo2);
            cc.Add(c1);
            cc.Add(c2);
            cc.Add(c3);
            listView.Adapter = new MyAdapter(this, cc);
            listView.ItemClick += OnListItemClick;
        }
        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = cc[e.Position];
            string cName = t.GetCityName.ToString();
            Toast.MakeText(this, cName, ToastLength.Short).Show();
            var intent = new Intent(this, typeof(DestinationCity));
            intent.PutExtra("Intent2", e.Position.ToString());
            StartActivity(intent);
        }
    }
}