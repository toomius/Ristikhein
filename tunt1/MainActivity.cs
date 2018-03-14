using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Risthein;

namespace Risthein
{
    [Activity(Label = "ToomasRisthein", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView carListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            carListView = FindViewById<ListView>(Resource.Id.carListView);

            List<Car> carList = new List<Car>();

            //carList.Add(new Car(1234, "autu","laheauto", Resource.Drawable.jaanus1));
            //carList.Add(new Car(4321, "autu", "teineauto", Resource.Drawable.jaanus2));
            //carList.Add(new Car(1999, "autu", "ilus", Resource.Drawable.jaanus3));
            //carList.Add(new Car(9876, "autu", "nunnu", Resource.Drawable.jaanus4));
            //carList.Add(new Car(6789, "autu", "lahe", Resource.Drawable.jaanus5));
            //carList.Add(new Car(8520, "autu", "cool", Resource.Drawable.jaanus6));
            //carList.Add(new Car(2580, "autu", "kewl", Resource.Drawable.jaanus7));
            carList.Add(new Car(9999, "autu", "kena", Resource.Drawable.jaanus8));
            carList.Add(new Car(4565, "autu", "miniclip", Resource.Drawable.jaanus9));
            carList.Add(new Car(7777, "autu", "aasta auto", Resource.Drawable.mihkel));
            ListViewAdapter adapter = new ListViewAdapter(this, carList);

            carListView.Adapter = adapter;
        }
    }
}

