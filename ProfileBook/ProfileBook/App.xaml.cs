using Prism;
using Prism.Ioc;
using Prism.Unity;
using ProfileBook.ViewModels;
using ProfileBook.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProfileBook
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        #region --- Overrides ---

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<SignInPage, SignInPageViewModel>();
            containerRegistry.RegisterForNavigation<MainListPage, MainListPageViewModel>();
            containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            containerRegistry.RegisterForNavigation<AddProfilePage, AddProfilePageViewModel>();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(SignInPage)}");
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

        #endregion
    }
}
