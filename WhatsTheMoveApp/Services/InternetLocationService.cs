using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace WhatsTheMoveApp.Services
{
    internal class InternetLocationService
    {
        static string BaseURL = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        static HttpClient client;
        
        static InternetLocationService()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri(BaseURL)
            };
        }

        public static async Task<IEnumerable<Location>> GetLocation()
        {
            var json = await client.GetStringAsync("api/Location");
            var locations = JsonConvert.DeserializeObject<IEnumerable<Location>>(json);
            return locations;
        }
    }
}
