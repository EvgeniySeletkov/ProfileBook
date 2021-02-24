using Prism.Mvvm;
using Prism.Navigation;
using ProfileBook.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProfileBook.ViewModels
{
    class SignInPageViewModel : BindableBase
    {
        INavigationService navigationService;

        private string title;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }


        public SignInPageViewModel(INavigationService navigationService)
        {
            Title = "Users SignIn";
            this.navigationService = navigationService;
        }

        public ICommand SignInCommand => new Command(SignIn);
        public ICommand SignUpCommand => new Command(SignUp);

        private async void SignIn()
        {
            await navigationService.NavigateAsync($"{nameof(MainListPage)}");
        }

        private async void SignUp()
        {
            await navigationService.NavigateAsync($"{nameof(SignUpPage)}");
        }
    }
}
