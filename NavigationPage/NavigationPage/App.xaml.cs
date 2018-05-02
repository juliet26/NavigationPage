using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NavigationPage
{
	public partial class App : Application
	{
		public App ()
		{

			InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            var navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackGroundColor = Color.Blue;
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;

            
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
