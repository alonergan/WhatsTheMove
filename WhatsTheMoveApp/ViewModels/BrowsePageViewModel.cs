using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WhatsTheMoveApp.Models;
using WhatsTheMoveApp.Services;
using WhatsTheMoveApp.Views;
using Xamarin.Forms;

namespace WhatsTheMoveApp.ViewModels
{
    internal class BrowsePageViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Location> Locations { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Location> RemoveCommand { get; }
        public BrowsePageViewModel()
        {

            Title = "Trending Locations";
            var BrookhavenLogo = "https://images.squarespace-cdn.com/content/v1/5defe6b5d6702f39f24e8ba0/1576009303487-FWX1WJKL4M5QYP6N171P/NEW+Brook+Haven+Logo.png?format=1500w";
            var YoungAveLogo = "https://www.youngavenuedeli.com/wp-content/uploads/2015/07/young-ave-deli_alpha_SM.png";

            Locations = new ObservableRangeCollection<Location>();

            
            Locations.Add(new Location { ID = 1, Name = "Knifebird", Rating = 9.0, LogoPath = YoungAveLogo });
            Locations.Add(new Location { ID = 2, Name = "Young Ave", Rating = 7.8, LogoPath = YoungAveLogo });
            Locations.Add(new Location { ID = 3, Name = "Brookhaven", Rating = 6.7, LogoPath = BrookhavenLogo });
            Locations.Add(new Location { ID = 4, Name = "Newbys", Rating = 6.9, LogoPath = YoungAveLogo });
            Locations.Add(new Location { ID = 5, Name = "The Bluff", Rating = 2.0, LogoPath = YoungAveLogo });
            Locations.Add(new Location { ID = 6, Name = "Windjammer", Rating = 9.9, LogoPath = YoungAveLogo });
            Locations.Add(new Location { ID = 7, Name = "Hog And Hominy", Rating = 9.4, LogoPath = YoungAveLogo });
            

            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<Location>(Remove);
        }

        async Task Add()
        {
        }

        async Task Remove(Location location)
        {
        }

        async Task Refresh()
        {
        }
    }
}
