using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;

namespace WcfServiceLib
{
    public class LocationService : ILocationService
    {
        static LocationController lCtr = new LocationController();

        public void InsertLocation(ModelLayer.Location location)
        {
            lCtr.InsertLocation(location);
        }

        public ModelLayer.Location GetLocation(string zipCode)
        {
            return lCtr.GetLocation(zipCode);
        }

        public List<ModelLayer.Location> GetLocationsByCity(string city)
        {
            return lCtr.GetLocationsByCity(city);
        }

        public List<ModelLayer.Location> GetAllLocations()
        {
            return lCtr.GetAllLocations();
        }

        public void UpdateLocation(ModelLayer.Location loc, string zipCode, string city)
        {
            lCtr.UpdateLocation(loc, zipCode, city);
        }

        public void DeleteLocation(ModelLayer.Location loc)
        {
            lCtr.DeleteLocation(loc);
        }
    }
}
