using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ModelLayer.DAL;
using ModelLayer;

namespace ControlLayer
{
    public class LocationController
    {
        public LocationController()
        {

        }

        public List<Location> DoStuff()
        {
            List<Location> locs;
            using (var ctx = new SystemContext())
            {
                Location loc = new Location() { ZipCode = "8800", City = "Viborg" };
                ctx.Locations.Add(loc);
                ctx.SaveChanges();
                //Console.WriteLine(loc.ZipCode + " " + loc.City);

                
                locs = ctx.Locations.ToList();
            }
            return locs;
        }
    }
}
