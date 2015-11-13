using ModelLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SystemContext())
            {
                Location loc = new Location() { ZipCode = "8800", City = "Viborg" };
                ctx.Locations.Add(loc);
                ctx.SaveChanges();
                Console.WriteLine(loc.ZipCode + " " + loc.City);
            }



        }
    }
}
