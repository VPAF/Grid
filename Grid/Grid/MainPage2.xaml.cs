using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage2 : ContentPage
	{
		public MainPage2 ()
		{
			InitializeComponent ();
		}

	    private void BtnLogin_OnClicked(object sender, EventArgs e)
	    {
	        DisplayAlert("Button Login has been clicked!", "Login Click","Cancel");
	    }

	    private void BtnRegister_OnClicked(object sender, EventArgs e)
	    {
	        DisplayAlert("Button Register has been clicked!", "Register Click", "Cancel");
        }
	}
}