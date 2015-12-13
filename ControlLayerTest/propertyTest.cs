/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * I den pågældende klasse findes der Unit Tests af ControlLayerets PropertyController.
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLayer;
using ModelLayer.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlLayer;

namespace ControlLayerTest
{
    [TestClass]
    public class propertyTest
    {
        private PropertyController pCtr;
        [TestInitialize]
        public void Initialize()
        {
            pCtr = new PropertyController();
        }

        [TestMethod]
        public void CreateTest()
        {
            //No properties does need to be created before the property itself 
            //Create the property itself 
            Property testProperty = new Property() { Address = "Sofiendalshej 60", ZipCode = "9000", Type = "Borg", Rooms = 4, Floors = 1, Price = 1000000, PropertySize = 1000, HouseSize = 100, ConstructionYear = 2000, SellerID = 1 };

            //Save it to the database and get amount of properties in db before and after save
            int CountDB = pCtr.GetAllProperties().ToList().Count;
            pCtr.InsertProperty(testProperty);
            int CountDBAfter = pCtr.GetAllProperties().ToList().Count;

            //Compare Properties. Maybe use conditions other than Adress?
            Assert.AreEqual<int>(CountDBAfter, CountDB + 1);
            pCtr.DeleteProperty(testProperty);
        }

        [TestMethod]
        public void ReadTest()
        {
            //No properties does need to be created before the property itself 
            //Create the property itself 
            Property testProperty = new Property() { Address = "Sofiendalshej 60", ZipCode = "9000", Type = "Borg", Rooms = 4, Floors = 1, Price = 1000000, PropertySize = 1000, HouseSize = 100, ConstructionYear = 2000, SellerID = 1 };

            //Save it to the database and get amount of properties in db before and after save
            pCtr.InsertProperty(testProperty);

            //Get property from database and assert not null
            Assert.IsNotNull(pCtr.GetPropertyByAddress(testProperty.Address));
            pCtr.DeleteProperty(testProperty);
        }

        [TestMethod]
        public void UpdateTest()
        {
            //No properties does need to be created before the property itself 
            //Create the property itself 
            Property testProperty = new Property() { Address = "Sofiendalshej 60", ZipCode = "9000", Type = "Borg", Rooms = 4, Floors = 1, Price = 1000000, PropertySize = 1000, HouseSize = 100, ConstructionYear = 2000, SellerID = 1 };

            //Save it to the database
            pCtr.InsertProperty(testProperty);

            //Change the property:
            pCtr.UpdateProperty(testProperty, "Her", "9000", "Borg", 4, 1, 1000000, 1000, 100, 2000);

            //Test the assertion
            Assert.IsNotNull(pCtr.GetPropertyByAddress("Her"));
            pCtr.DeleteProperty(testProperty);
        }

        [TestMethod]
        public void DeleteTest()
        {
            //No properties does need to be created before the property itself 
            //Create the property itself 
            Property testProperty = new Property() { Address = "Sofiendalshej 60", ZipCode = "9000", Type = "Borg", Rooms = 4, Floors = 1, Price = 1000000, PropertySize = 1000, HouseSize = 100, ConstructionYear = 2000, SellerID = 1 };
            
            //Save it to the database
            pCtr.InsertProperty(testProperty);

            //Delete it again
            pCtr.DeleteProperty(testProperty);

            //Try to retrieve the deleted property again, and assert it is null.
            Property testPropertyDB = pCtr.GetPropertyByAddress(testProperty.Address).SingleOrDefault();
            Assert.IsNull(testPropertyDB);
        }

    }
}
