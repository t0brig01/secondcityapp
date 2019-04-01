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
	public partial class AdminSettings : ContentPage
	{
		public AdminSettings ()
		{
			InitializeComponent ();
		}

        private async void NewRescueProfileClicked(object sender, EventArgs e)
        {
            //send the admin to the create a new rescue profile page
            await Navigation.PushAsync(new AdminSettings());
        }

        private void AdminLogOutClicked(object sender, EventArgs e)
        {
            //this will remove admin priviledges from this device
        }
    }
}