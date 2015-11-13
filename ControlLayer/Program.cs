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

            List<Location> locs = lc.DoStuff();
            Console.WriteLine(locs.Count);
            foreach(Location l in locs)
            {
                Console.WriteLine(l.Id + " " + l.ZipCode);
            }

            Console.ReadLine();
        }
    }
}
