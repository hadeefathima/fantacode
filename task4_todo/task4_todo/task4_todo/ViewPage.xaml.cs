using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace task4_todo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewPage : ContentPage
	{
		public ViewPage (List<string> mem)
		{
			InitializeComponent ();
            listview.ItemsSource = mem;
		}
	}
}