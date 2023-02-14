using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhatsTheMoveApp.Views;
using Xamarin.Forms;

namespace WhatsTheMoveApp.ViewModels
{
    internal class LoginPageViewModel : ViewModelBase
    {
        private string textUsername;
        private string textPassword;
        public AsyncCommand LoginCommand { get;  }
        public AsyncCommand SignUpCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new AsyncCommand(Login);
            SignUpCommand = new AsyncCommand(SignUp);
        }

        async Task Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(BrowsePage)}");
        }

        async Task SignUp()
        {
            await Shell.Current.GoToAsync($"{nameof(SignUpPage)}");
        }
    }
}
