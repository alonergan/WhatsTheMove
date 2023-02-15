using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WhatsTheMoveApp.Views;
using Xamarin.Forms;

namespace WhatsTheMoveApp.ViewModels
{
    internal class SignUpPageViewModel : ViewModelBase
    {
        public AsyncCommand RegisterCommand { get; }
        public AsyncCommand ReturnCommand { get; }

        public SignUpPageViewModel()
        {
            RegisterCommand = new AsyncCommand(Register);
            ReturnCommand = new AsyncCommand(Return);
        }

        async Task Register()
        {
            Console.WriteLine("USER REGISTERED");
        }

        async Task Return()
        {
            await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
        }
    }
}
