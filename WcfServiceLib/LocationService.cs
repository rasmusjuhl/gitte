using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;
using ModelLayer;

namespace WcfServiceLib
{
    public class LocationService : ILocationService
    {
        static LocationController lCtr = new LocationController();

        public void InsertLocation(Location location)
        {
            lCtr.InsertLocation(location);
        }

        public Location GetLocation(string zipCode)
        {
            return lCtr.GetLocation(zipCode);
        }

        public List<Location> GetLocationsByCity(string city)
        {
            return lCtr.GetLocationsByCity(city);
        }

        public List<Location> GetAllLocations()
        {
            return lCtr.GetAllLocations();
        }

        public void UpdateLocation(Location loc, string zipCode, string city)
        {
            lCtr.UpdateLocation(loc, zipCode, city);
        }

        public void DeleteLocation(Location loc)
        {
            lCtr.DeleteLocation(loc);
        }
    }
}
