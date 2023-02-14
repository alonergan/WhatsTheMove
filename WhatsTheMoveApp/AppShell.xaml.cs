using System;
using System.Collections.Generic;
using WhatsTheMoveApp.ViewModels;
using WhatsTheMoveApp.Views;
using Xamarin.Forms;

namespace WhatsTheMoveApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(BrowsePage), typeof(BrowsePage));
            Routing.RegisterRoute(nameof(UserProfilePage), typeof(UserProfilePage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));


        }

    }
}
