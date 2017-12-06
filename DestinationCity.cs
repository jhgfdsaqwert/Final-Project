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
    [Activity(Label = "DestinationCity")]
    public class DestinationCity : Activity
    {
        ImageView iv1;
        ImageView iv2;
        TextView tv1;
        TextView title;
        List<string> dataText = new List<string>();
        List<string> dataTitle = new List<string>();
        List<int> dataImg = new List<int>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.destinationCity);
            // Create your application here
            int index = Convert.ToInt32(Intent.GetStringExtra("Intent2"));
            iv1 = FindViewById<ImageView>(Resource.Id.imageView1);
            iv2 = FindViewById<ImageView>(Resource.Id.imageView2);
            tv1 = FindViewById<TextView>(Resource.Id.textView1);
            title = FindViewById<TextView>(Resource.Id.title);
            dataImg.Add(Resource.Drawable.venice);
            dataImg.Add(Resource.Drawable.berlin);
            dataImg.Add(Resource.Drawable.tokyo);
            dataTitle.Add("Venice");
            dataTitle.Add("Berlin");
            dataTitle.Add("Tokyo");
            dataText.Add("Venice is located in the north-eastern part of Italy, and is perhaps the most beautiful city in the world in 2014 year! This city is as beautiful as unique. The other, a little bit similar, there is no country in the world. He won a huge honor to be a World Heritage Site. Speaking of Venice, often uttered the phrase – “City of Water”, “City of Masks”, “City of Bridges” and “City Channel” and many others. ");
            dataText.Add("Berlin is one of the most transformative cities in the world, changing its step slowly and continuously since reuniting its split heart after thirty years of separation. The reunion of East and West Berlin has created a brand new identity, and one that’s far more exciting than when it was undone. Germany’s newly established capital has moved on to become a modern metropolis and a leading destination for the arts, architecture, shopping, and entertainment.");
            dataText.Add("Hitting the streets of Tokyo for the first time is like stepping into a weird and wonderful dream or a fast-paced sci-fi video game filled with neon lights. The city is ripe with tradition, but also charges forward with edgy trends, exhibiting a culture that, as a whole, happily embraces both ancient heritage and contemporary cultivation. Tokyo is so engulfing you could stand and stare for hours at the constant action.");
            title.Text = dataTitle[index];
            tv1.Text = dataText[index];
            iv1.SetImageResource(dataImg[index]);
        }
    }
}