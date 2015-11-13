using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            LocationController lc = new LocationController();

            string zipCode = "8800";
            Location loc = lc.GetLocation(zipCode);

            Console.WriteLine(zipCode + " " +loc.City);
           

            List<Location> locations = lc.GetAllLocations();
            Console.WriteLine(locations.Count);
            foreach (Location l in locations)
            {
                Console.WriteLine(l.Id + " " + l.ZipCode);
            }

            Console.ReadLine();
        }
    }
}
