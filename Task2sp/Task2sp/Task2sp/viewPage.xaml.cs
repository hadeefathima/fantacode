using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task2sp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class viewPage : ContentPage
	{
       // List<string> member;
        
        public viewPage (List<string> member)
		{
			InitializeComponent ();
          
            listview.ItemsSource = member;
        }
        //public interface ICloseApplication
        //{
        //    void closeApplication();
        //}
        //public class CloseApplication : ICloseApplication
        //{
        //    public void closeApplication()
        //    {
        //        var activity = (Activity)Forms.Context;
        //        activity.FinishAffinity();
        //    }
        //}

        

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            //var closer = DependencyService.Get<Class2>();
            //if (closer != null)
            //    closer.closeApplication();
            Boolean data = await DisplayAlert("EXIT", "DO U WANNA EXIT", "YES", "NO");
            if (data == true)
            {
                var activity = (Activity)Forms.Context;
                activity.FinishAffinity();
            }
        }
    }
}