using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WhatsTheMoveApp.ViewModels
{
    class LoadingPageViewModel : ViewModelBase
    {
        public LoadingPageViewModel() { }

        public async void Init()
        {
            var isAuthenticated = false; //await this.identityService.VerifyRegistration();
            if (isAuthenticated)
            {
                await Shell.Current.GoToAsync("///main");
            }
            else
            {
                await Shell.Current.GoToAsync("///login");
            }
        }
    }
}
