using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Location
    {
        public string ZipCode { get; set; }
        public string City { get; set; }
        public Location(string zipCode, string city)
        {
            this.ZipCode = zipCode;
            this.City = city;
        }
    }
}
