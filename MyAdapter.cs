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
    class MyAdapter : BaseAdapter<CityClass>
    {
        List<CityClass> items;
        Activity context;
        public MyAdapter(Activity context, List<CityClass> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override CityClass this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.listViewDis, null);
            view.FindViewById<TextView>(Resource.Id.itemName).Text = item.GetCityName;
            view.FindViewById<ImageView>(Resource.Id.icon).SetImageResource(item.GetGityImage);
            return view;
        }
    }
}