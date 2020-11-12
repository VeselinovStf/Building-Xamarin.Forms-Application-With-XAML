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
        public PieDetailPage()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            var pie = new Pie()
            {
                Id = 1,
                Name = "Mobile Pie",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                InStock = true,
                Price = 543,
                ImageURI = "piesImg.png"
            };

            Name.Text = pie.Name;
            Description.Text = pie.Description;
            InStock.Text= pie.InStock ? "In Stock" : "Out Of Strock";
            ImageURI.Source = pie.ImageURI;
            Price.Text = "$ " +  pie.Price;
        }

        private void AddToBasket_OnButtonClick(object sender, EventArgs e)
        {
            DisplayAlert("Added", "Your Pie is added to basket", "Done");
        }
    }
}