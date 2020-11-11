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
    public partial class PieDetailPage : ContentPage
    {
        public PieDetailPage()
        {
            InitializeComponent();
        }

        private void AddToBasket_OnButtonClick(object sender, EventArgs e)
        {
            DisplayAlert("Added", "Your Pie is added to basket", "Done");
        }
    }
}