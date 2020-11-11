﻿using BethanysPieShop.Views;
using Xamarin.Forms;

namespace BethanysPieShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new TabbedNavigationPage();
            //MainPage = new MasterDetailPageView();
            //MainPage = new CarouselPageView();
            MainPage = new NavigationPage( new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
