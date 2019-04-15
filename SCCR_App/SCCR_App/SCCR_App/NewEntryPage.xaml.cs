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
    public partial class NewEntryPage : ContentPage
    {
        public NewEntryPage(Entry entry)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var layout = new StackLayout();

            Image banner = new Image
            {
                Source = "SCCR_Logo.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand, 
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            ImageButton settingsButton = new ImageButton
            {
                Source = "settings.png",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                BackgroundColor = Color.Transparent
            };
            settingsButton.Clicked += OnSettingsButtonClicked;

            var Name = new Label { Text = "Name: " + entry.entryName, FontSize = 24, Margin = new Thickness(20, 3) };
            var Breed = new Label { Text = "Breed: " + entry.entryBreed, FontSize = 24, Margin = new Thickness(20, 3) };
            var Age = new Label { FontSize = 24, Margin = new Thickness(20, 3) };

            if(entry.entryAgeYears != null) {

                if (entry.entryAgeMonths != null)
                {
                    //if years = 1
                    if (entry.entryAgeYears == "1" || entry.entryAgeYears == "one" || entry.entryAgeYears == "One")
                    {
                        if (entry.entryAgeMonths == "1" || entry.entryAgeMonths == "one" || entry.entryAgeMonths == "One")
                        {
                            Age.Text = "Age: " + entry.entryAgeYears + " year and " + entry.entryAgeMonths + " month";
                        }
                        else
                        {
                            Age.Text = "Age: " + entry.entryAgeYears + " year and " + entry.entryAgeMonths + " months";
                        }
                    }
                    //otherwise
                    else
                    {
                        //if months == 1
                        if (entry.entryAgeMonths == "1" || entry.entryAgeMonths == "one" || entry.entryAgeMonths == "One")
                        {
                            Age.Text = "Age: " + entry.entryAgeYears + " years and " + entry.entryAgeMonths + " month";
                        }
                        //neither == 1
                        else
                        {
                            Age.Text = "Age: " + entry.entryAgeYears + " years and " + entry.entryAgeMonths + " months";
                        }                        
                    }
                //months == null
                }
                else
                {
                    //there's only years
                    if(entry.entryAgeYears == "1" || entry.entryAgeYears == "one" || entry.entryAgeYears == "One")
                    {
                        Age.Text = "Age: " + entry.entryAgeYears + " year";
                    }
                    //more than one year
                    else
                    {
                        Age.Text = "Age: " + entry.entryAgeYears + " years";
                    }                    
                }
            }
            else
            {
                Age.Text = "Age Unknown" ;
            }

            var Gender = new Label { Text = "Gender: " + entry.entryGender, FontSize = 24, Margin = new Thickness(20, 3) };
            var Fixed = new Label { Text = "Is Fixed: " + entry.entryFixed, FontSize = 24, Margin = new Thickness(20, 3) };

            DateTime localDate = DateTime.Now;

            var DatePosted = new Label { Text = "This dog's info was posted at: " + localDate.ToString(), FontSize = 14, Margin = new Thickness(20, 3) };

            Content = new StackLayout
            {
                Children = { banner, Name, Breed, Age, Gender, Fixed, DatePosted, settingsButton },
                Spacing = 10
            };

            InitializeComponent();
        }

        private async void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminLogin());
        }




    }




}