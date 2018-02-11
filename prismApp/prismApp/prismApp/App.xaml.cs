using prismApp.Interfaces;
using prismApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace prismApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
           



            MainPage = new prismApp.MainPage();
		}

     
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
