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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

            BirthdayDatePicker.Date = DateTime.Today;
            CreateAccountButton.IsEnabled = false;
        }

        private bool CheckCanRegister()
        {
            var userName = UserName.Text;
            var userPassword = Password.Text;
            var userEmail = Email.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(userEmail))
            {
                return false;
            }

            return true;
        }
        private void ButtonRegister_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "You Have Registered successfully", "Done");
        }

        private void UserNameEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CreateAccountButton.IsEnabled = CheckCanRegister();
        }

        private void EmailEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CreateAccountButton.IsEnabled = CheckCanRegister();
        }

        private void PasswordEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            CreateAccountButton.IsEnabled = CheckCanRegister();
        }

        private void BirthDayDatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            if (e.NewDate < DateTime.Now)
            {
                DisplayAlert("Note", "You weren't born back in time?", "Ok");

                BirthdayDatePicker.Date = DateTime.Today;
            }
        }
    }
}