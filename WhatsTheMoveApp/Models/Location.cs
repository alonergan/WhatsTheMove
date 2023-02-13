using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WhatsTheMoveApp.Models
{
    internal class Location
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string LogoPath { get; set; }
    }
}
