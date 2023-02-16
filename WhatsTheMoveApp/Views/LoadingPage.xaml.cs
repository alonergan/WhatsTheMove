using System;
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
	public partial class LoadingPage : ContentPage
	{
		internal LoadingPageViewModel ViewModel { get; set; }
		public LoadingPage ()
		{
			InitializeComponent();
			ViewModel = new LoadingPageViewModel();	

		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
			ViewModel.Init();
        }


    }
}