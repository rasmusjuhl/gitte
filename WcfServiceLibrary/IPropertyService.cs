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
    public interface IPropertyService
    {
        [OperationContract]
        void InsertProperty(Property property);
        [OperationContract]
        Property GetPropertyByAddress(string address);
        [OperationContract]
        List<Property> GetAllProperties();
        [OperationContract]
        void UpdateProperty(Property property, string address, string zipCode, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear);
        [OperationContract]
        void DeleteProperty(Property property);
    }
}
