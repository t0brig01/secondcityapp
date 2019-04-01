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
        private void AdminCredsClicked(object sender, EventArgs e)
        {
            //this button will send the credentials to check against the database or a hardcoded login built into the app, either way
            //if correct, this device will gain admin priviledges, meaning it allows a new option in the main page \
            //which will take the user to a new content page called profile
            //if incorrect, display an error message
        }
    }
}