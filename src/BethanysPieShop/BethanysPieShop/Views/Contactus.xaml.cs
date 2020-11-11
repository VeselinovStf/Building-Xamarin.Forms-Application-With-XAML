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
    public partial class Contactus : ContentPage
    {
        public Contactus()
        {
            InitializeComponent();
        }

        private void ButtonSendMessage_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message Send", "Your message is send to Bethany", "Done");
        }

        private void ContactClientSwitch_OnToggle(object sender, ToggledEventArgs e)
        {

        }
    }
}