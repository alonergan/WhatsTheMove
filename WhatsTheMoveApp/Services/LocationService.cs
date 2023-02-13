using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WhatsTheMoveApp.Models;
using Xamarin.Essentials;

namespace WhatsTheMoveApp.Services
{
    class LocationService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
            {
                // Already initialized database
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "WTM_Data.db");
            db = new SQLiteAsyncConnection(databasePath);

            Console.WriteLine("---- Initialized database connection ----");

            await db.CreateTableAsync<Models.Location>();
        }

        public static async Task AddLocation(int id, string name, double rating, string logoPath)
        {
            await Init();
            var location = new Models.Location
            {
                ID = id,
                Name = name,
                Rating = rating,
                LogoPath = logoPath
            };

            var newID = await db.InsertAsync(location);
        }

        public static async Task RemoveLocation(int ID)
        {
            await Init();

            await db.DeleteAsync<Models.Location>(ID);
        }

        public static async Task<IEnumerable<Models.Location>> GetLocation()
        {
            await Init();

            var locations = await db.Table<Models.Location>().ToListAsync();
            return locations;
        }
    }
}
