using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task3_2p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewPage : ContentPage
	{
		public ViewPage (String name,String email,String prof)
		{
			InitializeComponent ();
            nm.Text = name;
            el.Text = email;
            pf.Text = prof;
		}
	}
}