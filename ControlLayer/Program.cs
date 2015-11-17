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
        private static LocationController lc = new LocationController();
        static void Main(string[] args)
        {
            print();

            //Location loc = new Location() { ZipCode = "8000", City = "Aarhus" };
            //lc.InsertLocation(loc);
            
            //test af insert metode
            while (true)
            {
                Console.WriteLine("Indtast postnr");
                string zipCode = Console.ReadLine();
                Console.WriteLine("Indtast by");
                string city = Console.ReadLine();
                Location loc = new Location() { ZipCode = zipCode, City = city };
                lc.InsertLocation(loc);
            }
            
            //test af get metode
            //while (true)
            //{
            //    Console.WriteLine("Indtast postnr");
            //    string zipCode = Console.ReadLine();
            //    Location loc = lc.GetLocation(zipCode);
            //    Console.WriteLine(zipCode + " " + loc.City);
            //}

            //test af update
            //Location loc = lc.GetLocation("8000");
            //Console.WriteLine("Indtast postnr");
            //string zipCode = Console.ReadLine();
            //Console.WriteLine("Indtast by");
            //string city = Console.ReadLine();
            //lc.UpdateLocation(loc, zipCode, city);
            


            // test af delete
            //Location loc = lc.GetLocation("9000");
            //Console.WriteLine(loc.Id + " " + loc.ZipCode + " " + loc.City);
            //Console.ReadLine();
            //lc.DeleteLocation(loc);

            

            print();
            Console.ReadLine();
        }

        public static void print()
        {
            List<Location> locations = lc.GetAllLocations();
            Console.WriteLine(locations.Count);
            foreach (Location l in locations)
            {
                Console.WriteLine(l.Id + " " + l.ZipCode);
            }
        }
    }
}
