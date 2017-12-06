using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace task4_todo
{
	public partial class MainPage : ContentPage
	{
        List<string> member;
        public MainPage()
		{
			InitializeComponent();
            
        }
        public void View(object o, EventArgs e)
        {
            member = new List<string>();

            member.Add(item1.Text);
            member.Add(item2.Text);
            member.Add(item3.Text);
            member.Add(item4.Text);

             Navigation.PushAsync(new ViewPage(member));
        }
    }
}
