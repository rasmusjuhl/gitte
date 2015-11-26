using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface ILocationService
    {
        [OperationContract]
        void InsertLocation(Location location);
        [OperationContract]
        Location GetLocation(string zipCode);
        [OperationContract]
        List<Location> GetLocationsByCity(string city);
        [OperationContract]
        List<Location> GetAllLocations();
        [OperationContract]
        void UpdateLocation(Location loc, string zipCode, string city);
        [OperationContract]
        void DeleteLocation(Location loc);
    }
}
