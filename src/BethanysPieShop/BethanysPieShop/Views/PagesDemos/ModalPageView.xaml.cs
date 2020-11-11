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
    public partial class ModalPageView : ContentPage
    {
        public ModalPageView()
        {
            InitializeComponent();
        }

        private async void ButtonLargeImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LargeImagePage());
        }
    }
}