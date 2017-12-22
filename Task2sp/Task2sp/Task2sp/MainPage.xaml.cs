using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Task2sp
{
	public partial class MainPage : ContentPage
	{
        List<string> member;
      

        public MainPage()
		{
			InitializeComponent();
            member = new List<string>();
           
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {

            String drink = await DisplayActionSheet("choose", "cancel", "", "7up", "sprite", "miranda");
           if (drink == "7up")
            {
                 member.Add("7up");
                
            }
            else if (drink == "sprite")
            member.Add("sprite");
            
            else if (drink == "miranda")
              member.Add("miranda");
            
        
        }

        public async void Button_Clicked_1(object sender, EventArgs e)
        {
            String drink = await DisplayActionSheet("choose", "cancel","", "burgar", "sandwich", "pizza");
            if (drink == "burgar")
            {
                member.Add("burgar");
            }
            else if (drink == "sandwich")
                member.Add("sandwich");
            else if (drink == "pizza")
                member.Add("pizza");
        }

        public async void Button_Clicked_2(object sender, EventArgs e)
        {
            Boolean data=await  DisplayAlert("order placed", "DO U WANNA SAVE", "SAVE", "CANCEL");
            if(data==true)
            {  await Navigation.PushAsync(new viewPage(member)); }

        }
    }
}
