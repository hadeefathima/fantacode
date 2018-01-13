using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Animate
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void move(object sender, EventArgs e)
        {
            await mans.TranslateTo(300, 0, 1000, Easing.Linear);
           // await man.TranslateTo(0, 300, 1000, Easing.Linear);


        }
        public async void down(object sender, EventArgs e)
        {
           // await man.TranslateTo(300, 0, 1000, Easing.Linear);
            await mans.TranslateTo(300, 300, 1000);
            await mans.TranslateTo(0, 300, 1000);
            await mans.TranslateTo(0, 0, 1000);
            await mans.TranslateTo(150, 150, 1000, Easing.Linear);
            await mans.ScaleTo(5, 1000);


        }

    }
}
