using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Task3_2p
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private async void submit(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ViewPage(n.Text,em.Text,p.Text));
        }

    }
}
