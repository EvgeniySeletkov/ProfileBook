using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProfileBook.ViewModels
{
    class AddProfilePageViewModel : BindableBase
    {
        INavigationService navigationService;

        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public AddProfilePageViewModel(INavigationService navigationService)
        {
            Title = "Add Profile";
            this.navigationService = navigationService;
        }

        public ICommand SaveProfileCommand => new Command(SaveProfile);

        private async void SaveProfile()
        {
            await navigationService.GoBackAsync();
        }
    }
}
