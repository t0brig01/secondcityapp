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
	public partial class AdminLogin : ContentPage
	{
		public AdminLogin ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

        //you'll also need two event handler completed funcitons to handle what happens when the user hits enter after filling a text box
        //after filling username, completed should move it to the password box

        //after filling password, completed should call AdminCredsClicked, which will validate them

        private void AdminCredsClicked(object sender, EventArgs e)
        {
            //this button will send the credentials to check against the database or a hardcoded login built into the app, either way
            //if correct, this device will gain admin priviledges, meaning it allows a new option in the main page \
            //which will take the user to a new content page called profile
            //if incorrect, display an error message
        }
    }
}