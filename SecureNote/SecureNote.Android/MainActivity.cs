using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SecureNote.Android
{
    [Activity(Label = "SecureNote", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks HAHAHA!", count++); };

            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            Button secButton = FindViewById<Button>(Resource.Id.button1);

            secButton.Click += (object sender, EventArgs args) =>
            {
                var dialog = new AlertDialog.Builder(this);
                dialog.SetMessage("Wanna call?");
                dialog.SetNeutralButton("Ok", (s, a) =>
                { 
                    string ca = "3";
                });

                dialog.SetNegativeButton("Cnacel", (s, a) =>
                {

                });

                dialog.Show();
            };
        }
    }
}

