/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * "DBLayer" har ansvaret for at tilgå databasen med de informationer, som brugeren af systemet ønsker at sende med. DBLaget har ansvaret
 * for, igennem systemcontext at oprette en forbindelse til databasen i forbindelse med Entity Framework og foretage de ønskede ændringer.
 * Selve databasen bliver oprettet af Entity Framework i samarbejde med de modelklasser vi har i "ModelLayer".
*/
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
        public Property GetPropertyBySellerID(int sellerID)
        {
            Property property;
            using (var ctx = new SystemContext())
            {
                property = ctx.Properties.Where(x => x.SellerID == sellerID).SingleOrDefault();
            }
            return property;
        }

        public Property GetProperty(string address)
        {
            Property property;
            using (var ctx = new SystemContext())
            {
                property = ctx.Properties.Where(x => x.Address.Equals(address)).SingleOrDefault();
            }
            return property;
        }

        public List<Property> GetPropertiesByAddress(string adress)
        {
            List<Property> properties = new List<Property>();
            using (var ctx = new SystemContext())
            {
                List<Property> allProps = ctx.Properties.ToList();
                foreach (Property p in allProps)
                { 
                    if(p.Address.Contains(adress))
                    {
                        properties.Add(p);
                    }
                }   
            }
            return properties;
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
            
            using (var ctx = new SystemContext())
            {
                Property p = ctx.Properties.Where(x => x.Id == property.Id).SingleOrDefault();
                p.Address = address;
                p.ZipCode = zipCode;
                p.Type = type;
                p.Rooms = rooms;
                p.Floors = floors;
                p.Price = price;
                p.PropertySize = propertySize;
                p.HouseSize = houseSize;
                p.ConstructionYear = constructionYear;
                ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
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
