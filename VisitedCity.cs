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
    [Activity(Label = "VisitedCity")]
    public class VisitedCity : Activity
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
            SetContentView(Resource.Layout.visitedCity);
            // Create your application here
            int index = Convert.ToInt32(Intent.GetStringExtra("Intent1"));
            iv1 = FindViewById<ImageView>(Resource.Id.imageView1);
            iv2 = FindViewById<ImageView>(Resource.Id.imageView2);
            tv1 = FindViewById<TextView>(Resource.Id.textView1);
            title = FindViewById<TextView>(Resource.Id.title);
            dataImg.Add(Resource.Drawable.ForbiddenCity);
            dataImg.Add(Resource.Drawable.roma);
            dataImg.Add(Resource.Drawable.paris);
            dataTitle.Add("Beijing");
            dataTitle.Add("Rome");
            dataTitle.Add("Paris");
            dataText.Add("Forbidden City, also known as the Palace Museum, and Gu Gong in Chinese, lies at the city center of Beijing, and once served as the imperial palace for 24 emperors during the Ming and Qing Dynasties (1368 - 1911). The Palace for the emperor on earth was so called the Purple City. It was forbidden to enter without special permission of the emperor. Hence its name 'The Purple Forbidden City', usually 'The Forbidden City'.");
            dataText.Add("The most famous emperor Julius Caesar is a city, probably the vast majority of people, even a little familiar with the history and culture of Rome, knows the name. Rome, one of the most beautiful cities in the world. There are many monuments of architecture, of which many have heard and visited possible. Probably one of the most famous – the Colosseum. Also, to not less colorful and breathtaking architectural buildings include Trajan’s Forum, the Pantheon, Raphael’s tomb, temples and churches, baths, imperial palaces.");
            dataText.Add("Paris – the city of love and romance is undoubtedly one of the best and most beautiful cities in the world. The most famous features, glorified this beautiful city – Eiffel Tower and French cheese. Since Paris is the capital of France, it was and still is the center of all the important political events in the country, beginning with the French Revolution. France is famous mainly because of this amazing beautiful city. Gorgeous perfume and gourmet cuisine has its origins precisely in Paris. ");
            title.Text = dataTitle[index];
            tv1.Text = dataText[index];
            iv1.SetImageResource(dataImg[index]);
        }
    }
}