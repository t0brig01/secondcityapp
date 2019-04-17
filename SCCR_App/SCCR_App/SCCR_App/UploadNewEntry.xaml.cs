using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using System.IO;
using System.Drawing;

namespace SCCR_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UploadNewEntry : ContentPage
    {
        public UploadNewEntry()
        {
            NavigationPage.SetHasNavigationBar(this, false);           

            InitializeComponent();
        }

        private async void UploadButtonClicked(object sender, EventArgs e)
        {
            //create new entry in entry class with the fields 
            //await DisplayAlert("Upload", "Are you sure you'd like to upload?", "Yes", "No");
            Entry thisEntry = new Entry
            {
                entryName = Entry_Name.Text,
                entryBreed = Entry_Breed.Text,
                entryAgeYears = Entry_Age_Years.Text,
                entryAgeMonths = Entry_Age_Months.Text,
                entryFixed = Entry_Fixed.Text,
                entryGender = Entry_Gender.Text,
                Pic1 = imageView

            };
            //cancel should not progress past this point
            await DisplayAlert("Uploading", "Uploading", "OK");
                        //
            UploadEntry(thisEntry);            
        }

        private async void ImageButton(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                return;
            }
            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,

            });


            if (file == null)
                return;

            imageView.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
                file.Dispose();
                return stream;
            });
        }
        //receives entry containing all the info to be uploaded
        private async void UploadEntry(Entry entry)
        {
            //push to database here
            await Navigation.PushAsync(new NewEntryPage(entry));

            //then navigate back to main page
        }


    }
}