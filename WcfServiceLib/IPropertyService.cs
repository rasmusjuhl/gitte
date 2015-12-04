using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;

namespace WcfServiceLib
{
    [ServiceContract]
    public interface IPropertyService
    {
        [OperationContract]
        void InsertProperty(Property property);
        [OperationContract]
        List<Property> GetPropertiesByAddress(string address);
        [OperationContract]
        List<Property> GetAllProperties();
        [OperationContract]
        void UpdateProperty(Property property, string address, string zipCode, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear);
        [OperationContract]
        void DeleteProperty(Property property);
        [OperationContract]
        Property GetPropertyBySellerID(int sellerID);
    }
}
