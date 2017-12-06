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
    [Activity(Label = "VisitedListActivity")]
    public class VisitedListActivity : Activity
    {
        ListView listView;
        List<CityClass> cc = new List<CityClass>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.visitedLayout);
            // Create your application here
            listView = FindViewById<ListView>(Resource.Id.listView1);
            CityClass c1 = new CityClass("Beijing", Resource.Drawable.beijing);
            CityClass c2 = new CityClass("Rome", Resource.Drawable.roma2);
            CityClass c3 = new CityClass("Paris", Resource.Drawable.paris2);
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
            var intent = new Intent(this, typeof(VisitedCity));
            intent.PutExtra("Intent1", e.Position.ToString());
            StartActivity(intent);
        }
    }
}