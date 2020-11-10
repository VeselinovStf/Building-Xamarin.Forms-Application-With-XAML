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
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void HomePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        private async void PieOverviewPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PieOverviewPage());

        }

        private async void Basket_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasketPage());

        }

        private async void ContactUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactusPage());

        }
    }
}