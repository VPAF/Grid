using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]

namespace Grid
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new Grid.MainPage();
            //MainPage = new Grid.MainPage2();
            //MainPage = new Grid.AbsoluteLayout();
            //MainPage = new Grid.AbsoluteLayout2();
            //MainPage = new Grid.RelativeLayout();
		    MainPage = new Grid.QuotesPage();
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
