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
    class CityClass
    {
        private string cityName;
        private int cityImage;
        private string cityDate;
        public CityClass(string cityName, int cityImage, string cityDate)
        {
            this.cityName = cityName;
            this.cityImage = cityImage;
            this.cityDate = cityDate;
        }
        public string GetCityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
        public int GetGityImage
        {
            get { return cityImage; }
            set { cityImage = value; }
        }
    }
}