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
        public List<Location> GetAllLocations()
        {
            return lCtr.GetAllLocations();
        }
    }
}
