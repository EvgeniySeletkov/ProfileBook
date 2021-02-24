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
    class MainListPageViewModel : BindableBase
    {
        INavigationService navigationService;

        private string title;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public MainListPageViewModel(INavigationService navigationService)
        {
            Title = "Main List";
            this.navigationService = navigationService;
        }

        public ICommand AddProfileCommand => new Command(AddProfile);
        public ICommand SignOutCommand => new Command(SignOut);

        private async void AddProfile()
        {
            await navigationService.NavigateAsync($"{nameof(AddProfilePage)}");
        }

        private async void SignOut()
        {
            await navigationService.GoBackAsync();
        }
    }
}
