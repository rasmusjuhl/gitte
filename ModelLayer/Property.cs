using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    class Property
    {
        public string Address { get; set; }
        public Location Location { get; set; }
        public string Type { get; set; }
        public int Rooms { get; set; }
        public int Floors { get; set; }
        public double Price { get; set; }
        public double PropertySize { get; set; }
        public double HouseSize { get; set; }
        public int ConstructionYear { get; set; }

        public Property(string address, Location location, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear)
        {
            this.Address = address;
            this.Location = location;
            this.Type = type;
            this.Rooms = rooms;
            this.Floors = floors;
            this.Price = price;
            this.PropertySize = propertySize;
            this.HouseSize = houseSize;
            this.ConstructionYear = constructionYear;
        }
    }
}
