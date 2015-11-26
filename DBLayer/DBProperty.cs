using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;

namespace DBLayer
{
    public class DBProperty
    {
        private DBLocation dbLoc = new DBLocation();
        public DBProperty()
        {

        }

        public void InsertProperty(Property property)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Properties.Add(property);
                ctx.SaveChanges();
            }
        }

        public Property GetPropertyByAddress(string address)
        {
            Property property;
            using (var ctx = new SystemContext())
            {
                property = ctx.Properties.Where(x => x.Address == address).Single();
            }
            return property;
        }

        public List<Property> GetAllProperties()
        {
            List<Property> properties;
            using (var ctx = new SystemContext())
            {
                properties = ctx.Properties.ToList();
            }
            return properties;
        }

        public void UpdateProperty(Property property, string address, string zipCode, string type, int rooms, int floors, double price,
            double propertySize, double houseSize, int constructionYear)
        {
            property.Address = address;
            property.ZipCode = zipCode;
            property.Type = type;
            property.Rooms = rooms;
            property.Floors = floors;
            property.Price = price;
            property.PropertySize = propertySize;
            property.HouseSize = houseSize;
            property.ConstructionYear = constructionYear;
            using (var ctx = new SystemContext())
            {
                ctx.Entry(property).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteProperty(Property property)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Properties.Attach(property);
                ctx.Properties.Remove(property);
                ctx.SaveChanges();
            }
        }

    }
}
