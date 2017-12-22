using Android.App;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Task2sp
{
   public class Class2
    {
    public void closeApplication()
        {
            var activity = (Activity)Forms.Context;
            activity.FinishAffinity();
        }
    
}
}
