using ProfileBook.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProfileBook
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainListPage());
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
