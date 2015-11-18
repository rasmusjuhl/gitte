using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using ModelLayer.DAL;
using ModelLayer;

using System.Data.SqlClient;
using System.Data;
using System.Data.Common;


namespace ControlLayer
{
    public class LocationController
    {

        public LocationController()
        {

        }


        

        public void InsertLocation(Location location)
        {
            using (var ctx = new SystemContext())
            {
                //string sql = "Insert into Locations(zipCode, city) Values(@zipCode, @city)";
                //ctx.Locations.SqlQuery(sql, new SqlParameter("@zipCode", location.ZipCode), new SqlParameter("@city", location.City));
                ctx.Locations.Add(location);
                ctx.SaveChanges();
            }
        }
        public Location GetLocation(string zipCode)
        {
            Location loc;
            using (var ctx = new SystemContext())
            {
                string sql = "Select * from Locations Where ZipCode = @zipCode";
                loc = ctx.Locations.SqlQuery(sql, new SqlParameter("@zipCode", zipCode)).Single();
            }
            return loc;
        }

        public List<Location> GetLocationsByCity(string city)
        {
            using (var ctx = new SystemContext())
            {
                var loc = ctx.Locations.Where(l => l.City.Contains(city));
                return loc.ToList();
            }
        }

        public List<Location> GetAllLocations()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Locations.ToList();
            }
        }

        public void UpdateLocation(Location loc, string zipCode, string city)
        {
            loc.ZipCode = zipCode;
            loc.City = city;
            using (var ctx = new SystemContext())
            {
                ctx.Entry(loc).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteLocation(Location loc)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Locations.Attach(loc);
                ctx.Locations.Remove(loc);
                ctx.SaveChanges();
            }
        }
    }
}
