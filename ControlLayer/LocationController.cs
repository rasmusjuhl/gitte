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

        public List<Location> GetAllLocations()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Locations.ToList();
            } 
        }

      
    }
}
