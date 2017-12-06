using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;
using System.Collections.Generic;

namespace BlogApp
{
    [Activity(Label = "BlogApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btn = FindViewById<Button>(Resource.Id.button1);
            btn.Click += delegate
            {
                PopupMenu popMenu = new PopupMenu(this, btn);
                popMenu.Inflate(Resource.Menu.menu);
                popMenu.MenuItemClick += MenuItem_Click;
                popMenu.Show();
            };
        }

        private void MenuItem_Click(object sender, PopupMenu.MenuItemClickEventArgs e)
        {
            string option = e.Item.TitleFormatted.ToString();
            switch(option)
            {
                case "Visited List":
                    StartActivity(typeof(VisitedListActivity));
                    break;
                case "Destination List":
                    StartActivity(typeof(DestinationActivity));
                    break;
                case "Contact Me":
                    StartActivity(typeof(ConnectActivity));
                    break;
            }
        }
    }
}

