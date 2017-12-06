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
    [Activity(Label = "ConnectActivity")]
    public class ConnectActivity : Activity
    {
        Button call;
        Button sms;
        Button email;
        EditText input;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.connectLayout);
            call = FindViewById<Button>(Resource.Id.callBtn);
            sms = FindViewById<Button>(Resource.Id.smsBtn);
            email = FindViewById<Button>(Resource.Id.emailBtn);
            input = FindViewById<EditText>(Resource.Id.editText1);
            call.Click += Call_Click;
            call.Click += delegate
            {
                var url1 = Android.Net.Uri.Parse("tel:6477088494");
                var intent = new Intent(Intent.ActionCall, url1);
                StartActivity(intent);
            };
            sms.Click += Sms_Click;
            sms.Click += delegate
            {
                var smsUri = Android.Net.Uri.Parse("smsto:1112223333");
                var smsIntent = new Intent(Intent.ActionSendto, smsUri);
                smsIntent.PutExtra("sms_body", input.Text);
                StartActivity(smsIntent);
            };
            email.Click += Email_Click;
            email.Click += delegate
            {
                var em = new Intent(Android.Content.Intent.ActionSend);
                em.PutExtra(Android.Content.Intent.ExtraEmail, new string[] { "qq384958448@gmail.com" });
                em.PutExtra(Android.Content.Intent.ExtraCc, new string[] { "583974312@qq.com" });
                em.PutExtra(Android.Content.Intent.ExtraText, "This is extra text.");
                em.SetType("message/rfc822");
                StartActivity(Intent.CreateChooser(em, "Send"));
            };
        }

        private void Email_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Send a email", ToastLength.Short).Show();
        }

        private void Sms_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Send a message", ToastLength.Short).Show(); ;
        }

        private void Call_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Make a call", ToastLength.Short).Show();
        }
    }
}