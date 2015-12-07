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
    public class PropertyService : IPropertyService
    {
        static PropertyController pCtr = new PropertyController();

        public void InsertProperty(Property property)
        {
            pCtr.InsertProperty(property);
        }

        public List<Property> GetPropertiesByAddress(string address)
        {
            return pCtr.GetPropertyByAddress(address);
        }

        public List<Property> GetAllProperties()
        {
            return pCtr.GetAllProperties();
        }

        public void UpdateProperty(Property property, string address, string zipCode, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear)
        {
            pCtr.UpdateProperty(property, address, zipCode, type, rooms, floors, price, propertySize, houseSize, constructionYear);
        }

        public void DeleteProperty(Property property)
        {
            pCtr.DeleteProperty(property);
        }

        public Property GetProperty(string address)
        {
            return pCtr.GetProperty(address);
        }


        public Property GetPropertyBySellerID(int sellerID)
        {
            return pCtr.GetPropertyBySellerID(sellerID);
        }
    }
}
