using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsTablePage : ContentPage
    {
        public SettingsTablePage()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            var languages = new List<string>() { "English", "Bulgarian", "Russian" };

            LanguagePicker.ItemsSource = languages;
        }

        private void LanguagePicker_OnSelectedIndexChange(object sender, EventArgs e)
        {
            var selectedIndex = ((Picker)sender).SelectedIndex;

            if (selectedIndex != -1)
            {
                LanguagePicker.SelectedItem = LanguagePicker.ItemsSource[selectedIndex];
                //SelectedLanguageLabel.Text = (string)LanguagePicker.ItemsSource[selectedIndex];
            }
        }


        private async void SaveSettings_OnButtonClicked(object sender, EventArgs e)
        {
            SavingActivityIndicator.IsRunning = true;

            await Task.Delay(2000);

            SavingActivityIndicator.IsRunning = false;

            await DisplayAlert("Saved", "Your settings are saved", "Done");
        }
    }
}