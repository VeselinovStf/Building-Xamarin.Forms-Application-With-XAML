using BethanysPieShop.Models;
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
     
        public PieDetailPage(Pie pie)
        {
            InitializeComponent();

            Load(pie);
        }

        private void Load(Pie pie)
        {

            Name.Text = pie.Name;
            Description.Text = pie.Description;
            InStock.Text= pie.InStock ? "In Stock" : "Out Of Strock";
            ImageURI.Source = pie.ImageURI;
            Price.Text = "$ " +  pie.Price;
        }

        private void AddToBasket_OnButtonClick(object sender, EventArgs e)
        {
            DisplayAlert("Added", "Your Pie is added to basket", "Done");
            AddToBasketButton.IsEnabled = false;
        }
    }
}