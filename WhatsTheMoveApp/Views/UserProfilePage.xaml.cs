﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsTheMoveApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsTheMoveApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfilePage : ContentPage
	{
		public UserProfilePage ()
		{
			InitializeComponent ();
			BindingContext = new UserProfilePageViewModel();
		}
	}
}