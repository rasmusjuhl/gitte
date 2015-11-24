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
using DBLayer;


namespace ControlLayer
{
    public class LocationController
    {
        private DBLocation dbLoc = new DBLocation();
        public LocationController()
        {

        }

        public void InsertLocation(Location location)
        {
            dbLoc.InsertLocation(location);
        }
        public Location GetLocation(string zipCode)
        {
            return dbLoc.GetLocation(zipCode);
        }

        public List<Location> GetLocationsByCity(string city)
        {
            return dbLoc.GetLocationsByCity(city);
        }

        public List<Location> GetAllLocations()
        {
            return dbLoc.GetAllLocations();
        }

        public void UpdateLocation(Location loc, string zipCode, string city)
        {
            dbLoc.UpdateLocation(loc, zipCode, city);
        }

        public void DeleteLocation(Location loc)
        {
            dbLoc.DeleteLocation(loc);
        }
    }
}
