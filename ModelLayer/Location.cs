using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Location
    {
        public Location()
        {
            this.Buyers = new List<Buyer>();
        }
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public ICollection<Buyer> Buyers { get; set; }
    }
}
