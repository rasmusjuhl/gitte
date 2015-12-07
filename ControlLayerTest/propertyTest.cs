using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLayer;
using ModelLayer.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlLayerTest
{
    [TestClass]
    public class propertyTest
    {
        [TestInitialize]
        public void Initialize()
        {
        }
        
        [TestMethod]
        public void CreateAndReadTest()
        {
            using (var context = new SystemContext())
            {
                //No properties does need to be created before the property itself 
                //Create the property itself 
                Property testProperty = new Property() { Address = "Sofiendalshej 60", ZipCode = "9000", Type = "Borg", Rooms = 4, Floors = 1, Price = 1000000, PropertySize = 1000, HouseSize = 100, ConstructionYear = 2000, SellerID = 1 };
                //Save it to the database
                context.Properties.Add(testProperty);
                context.SaveChanges();

                //Compare Properties. Maybe use conditions other than Adress?
                Property testPropertyDB = context.Properties.Where(x => x.Address == "Sofiendalshej 60").Single();
                Assert.AreEqual<Property>(testProperty, testPropertyDB);
                context.Properties.Remove(testProperty);
                context.SaveChanges();
            }
        }
    }
}
