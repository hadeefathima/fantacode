using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace task5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class listpage : ContentPage
	{
		public listpage (System.Collections.ObjectModel.ObservableCollection<Models.TaskModel> _list)
		{
			InitializeComponent ();
		}
	}
}