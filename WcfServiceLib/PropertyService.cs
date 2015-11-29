using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;

namespace WcfServiceLib
{
    public class PropertyService : IPropertyService
    {
        static PropertyController pCtr = new PropertyController();

        public void InsertProperty(ModelLayer.Property property)
        {
            pCtr.InsertProperty(property);
        }

        public List<ModelLayer.Property> GetPropertiesByAddress(string address)
        {
            return pCtr.GetPropertyByAddress(address);
        }

        public List<ModelLayer.Property> GetAllProperties()
        {
            return pCtr.GetAllProperties();
        }

        public void UpdateProperty(ModelLayer.Property property, string address, string zipCode, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear)
        {
            pCtr.UpdateProperty(property, address, zipCode, type, rooms, floors, price, propertySize, houseSize, constructionYear);
        }

        public void DeleteProperty(ModelLayer.Property property)
        {
            pCtr.DeleteProperty(property);
        }
    }
}
