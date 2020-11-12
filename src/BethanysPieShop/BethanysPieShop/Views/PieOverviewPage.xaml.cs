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
    public partial class PieOverviewPage : ContentPage
    {
        public IList<Pie> Pies = new List<Pie>()
            {
                new Pie()
                {
                             Id = 1,
                             Name = "Apple Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 123,
                             ImageURI = "piesImg.png"
                        },
                        new Pie()
                {
                    Id = 1,
                             Name = "Chery Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 234,
                             ImageURI = "piesImg.png"
                        },
                        new Pie()
                {
                    Id = 1,
                             Name = "Pine Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 432,
                             ImageURI = "piesImg.png"
                        },
                        new Pie()
                {
                    Id = 1,
                             Name = "Orange Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 234,
                             ImageURI = "piesImg.png"
                        },
                        new Pie()
                {
                    Id = 1,
                             Name = "Code Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 654,
                             ImageURI = "piesImg.png"
                        },
                        new Pie()
                {
                    Id = 1,
                             Name = "Pizza Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 76,
                             ImageURI = "piesImg.png"
                        },
                        new Pie()
                {
                    Id = 1,
                             Name = "Hulk Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 321,
                             ImageURI = "piesImg.png"
                        },
                        new Pie()
                {
                    Id = 1,
                             Name = "Mobile Pie",
                             Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled.",
                             InStock = true,
                             Price = 543,
                             ImageURI = "piesImg.png"
                        },
            };

        public PieOverviewPage()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            //Hardcoded Collection

            PieOverviewList.ItemsSource = Pies;


            PieOverviewList.RefreshCommand = new Command(() =>
            {
                ReloadData();
                PieOverviewList.IsRefreshing = false;
            });
        }

        private void ReloadData()
        {
            var pies = Pies.OrderBy(p => p.Price);

            PieOverviewList.ItemsSource = pies;
        }

        private async void PieOverviewList_OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPie = e.SelectedItem as Pie;

            await Navigation.PushAsync(new PieDetailPage(selectedPie));
        }
    }
}