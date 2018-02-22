using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}
        String un = UserName;
        private static ISettings AppSettings =>
    CrossSettings.Current;

        public static string UserName
        {
            get => AppSettings.GetValueOrDefault(nameof(UserName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(UserName), value);
        }
        //private static ISettings AppSettings
        //{
        //    get
        //    {
        //        if (CrossSettings.IsSupported)
        //            return CrossSettings.Current;

        //        return null; // or your custom implementation 
        //    }
        //}
    }
}
