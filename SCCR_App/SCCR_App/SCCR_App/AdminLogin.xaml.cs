using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCCR_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdminLogin : ContentPage
	{

        private String AdminUsername = "SCCR";
        private String AdminPassword = "password";

		public AdminLogin ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}
        
        //after filling password, completed should call AdminCredsClicked, which will validate them

        private async void AdminCredsClicked(object sender, EventArgs e)
        {
            //this button will send the credentials to check against the database or a hardcoded login built into the app, either way
            //if correct, this device will gain admin priviledges, meaning it allows a new option in the main page \
            //which will take the user to a new content page called profile
            //if incorrect, display an error message

            if (Username.Text.Equals(AdminUsername))
            {
                
                if (Password.Text.Equals(AdminPassword))
                {                    
                    await DisplayAlert("Login", "Login Successful", "OK");
                    AdminLoginApproved();
                }
                else
                {
                    await DisplayAlert("Error", "Incorrect Password", "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Incorrect username or password", "OK");
            }
        }

        //Login successful!
        private async void AdminLoginApproved()
        {
            await Navigation.PushAsync(new UploadNewEntry());
        }
    }
}