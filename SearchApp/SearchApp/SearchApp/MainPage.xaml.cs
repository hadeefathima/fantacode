using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SearchApp
{
	public partial class MainPage : ContentPage
	{
        private readonly List<string> _names = new List<string>
        {
            "Adnan","Adil","Lulu","jasna","fida","husna"
        };
		public MainPage()
		{
			InitializeComponent();
            MainList.ItemsSource = _names;
		}
        private void searchbut(object sender,EventArgs e)
        {
            string keyword = MainSearch.Text;
            IEnumerable<string> searchResult = _names.Where(name => name.Contains(keyword));
            MainList.ItemsSource = searchResult;
        }
	}
}
