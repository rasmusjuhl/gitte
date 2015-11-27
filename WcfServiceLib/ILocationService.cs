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
    [ServiceContract]
    public interface ILocationService
    {
        [OperationContract]
        List<Location> GetAllLocations();
    }
}
