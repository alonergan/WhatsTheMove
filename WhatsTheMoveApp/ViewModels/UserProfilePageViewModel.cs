using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhatsTheMoveApp.Views;
using Xamarin.Forms;

namespace WhatsTheMoveApp.ViewModels
{
    internal class UserProfilePageViewModel : ViewModelBase
    {
        public AsyncCommand LogoutCommand { get; }

        public UserProfilePageViewModel()
        {
            LogoutCommand = new AsyncCommand(Logout);
        }

        async Task Logout()
        {
            var route = $"{nameof(LoginPage)}";
            await Shell.Current.GoToAsync(route);
        }
    }
}
