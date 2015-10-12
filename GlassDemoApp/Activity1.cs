using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Google.Android.Glass.App;

namespace GlassDemoApp
{
    [Activity(Label = "GlassDemoApp", MainLauncher = true, Icon = "@drawable/icon")]
    [IntentFilter(new[] { "com.google.android.glass.action.VOICE_TRIGGER" })]
    [MetaData("com.google.android.glass.VoiceTrigger", Resource = "@xml/use_csharp")]
    public class Activity1 : Activity
    {
   

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var card = new Card(this);
            card.SetText("Xamarin on Glass is awesome");

            SetContentView(card.ToView());

        }
    }
}

