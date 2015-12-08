using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;
using DBLayer;

namespace ControlLayer
{
    public class PropertyController
    {
        private DBProperty dbProp = new DBProperty();
        public PropertyController()
        {

        }

        public void InsertProperty(Property property)
        {
            dbProp.InsertProperty(property);
        }

        public Property GetProperty(string address)
        {
            return dbProp.GetProperty(address);
        }

        public List<Property> GetPropertyByAddress(string address)
        {
            return dbProp.GetPropertiesByAddress(address);
        }

        public List<Property> GetAllProperties()
        {
            return dbProp.GetAllProperties();
        }
        public Property GetPropertyBySellerID(int sellerID)
        {
            return dbProp.GetPropertyBySellerID(sellerID);
        }

        public void UpdateProperty(Property property, string address, string zipCode, string type, int rooms, int floors, double price,
            double propertySize, double houseSize, int constructionYear)
        {
            dbProp.UpdateProperty(property, address, zipCode, type, rooms, floors, price, propertySize, houseSize, constructionYear);
        }

        public void DeleteProperty(Property property)
        {
            dbProp.DeleteProperty(property);
        }
    }
}
