using BethanysPieShop.Models;
using BethanysPieShop.Views;
using System;
using Xamarin.Forms;

namespace BethanysPieShop
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            masterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
        }

        private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem is MasterDetailNavigationItem item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                masterView.NavigationListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
