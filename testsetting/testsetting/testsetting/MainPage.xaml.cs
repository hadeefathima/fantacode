using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using testsetting.Helpers;

namespace testsetting
{
	public partial class MainPage : ContentPage

	{
        public string displaylan { get; set; }
		public MainPage()
		{
			InitializeComponent();
            displaylan = Settings.DisplayLanguage;
            BindingContext=this;
           // h.Text = displaylan;


        }
    //    Label heading = new Label
    //    {
    //        Text = "Display Language is " + testsetting.Helpers.Settings.DisplayLanguage,
    //        HorizontalOptions = LayoutOptions.CenterAndExpand,
    //        FontAttributes = FontAttributes.Bold
    //    };
    }
}
