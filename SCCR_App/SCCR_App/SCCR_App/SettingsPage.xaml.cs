using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCCR_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}
        private async void AdminSettingsClicked(object sender, EventArgs e)
        {
            //if this device is already logged in as an admin, 
            //await Navigation.PushAsync(new NavigationPage(new AdminSettings()));

            //otherwise, it's not logged in as an admin
            await Navigation.PushAsync(new NavigationPage(new AdminLogin()));
        }
    }
}