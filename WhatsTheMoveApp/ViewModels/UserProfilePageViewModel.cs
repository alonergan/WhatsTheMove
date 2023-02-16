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
        public string ProfileImage;

        public UserProfilePageViewModel()
        {
            LogoutCommand = new AsyncCommand(Logout);
            ProfileImage = "C:\\Users\\aflon\\Desktop\\WhatsTheMove\\beta\\WhatsTheMoveApp\\WhatsTheMoveApp.Android\\Resources\\drawable";
        }

        async Task Logout()
        {
            await Shell.Current.GoToAsync("//main/login");
        }
    }
}
