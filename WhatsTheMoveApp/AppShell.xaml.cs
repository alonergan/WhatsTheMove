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
            Routing.RegisterRoute("signup", typeof(SignUpPage));
            Routing.RegisterRoute("main/login", typeof(LoginPage));
            //Routing.RegisterRoute("main/browse", typeof(BrowsePage));
            //Routing.RegisterRoute("main/profile", typeof(UserProfilePage));
            BindingContext = this;

        }

    }
}
