using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SCCR_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            
        }
        private async void SettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminLogin());
        }

        public void LoadEntries()
        {
            //access db and store entries in an array

            //if there are no entries, display a null message

            //otherwise{

            //for each loop
            //for each field in the loop, display the content, putting most recent at the top

        }

        public void DisplayEntry(Object entry)
        {

        }
    }
}
