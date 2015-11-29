using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLayer;
using ModelLayer.DAL;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ControlLayerTest
{
    [TestClass]
    public class SellerTest
    {
        [TestInitialize]
        public void Initialize()
        { 
        }

        [TestMethod]
        public void CreateAndReadTest()
        {
            using (var ctx = new SystemContext())
            {
                //Create necessary list for seller.
                List<Property> propertyList = new List<Property>();

                //Create the seller itself.
                Seller sellDatHouse = new Seller() { Name = "Mr. Sell D. House", Address = "Sofiendalsvej 60", Email = "sell@house.com", Misc = "Han vil virkelig gerne have sit hus solgt", Mobile = "40528283", Phone = "40528283", ZipCode = "9000", Properties = propertyList };
                //Save it to the database
                ctx.Sellers.Add(sellDatHouse);
                ctx.SaveChanges();

                //Compare sellers.
                Seller sellDatHouseFromDB = ctx.Sellers.Where(x => x.Name == "Mr. Sell D. House").Single();
                Assert.AreEqual<Seller>(sellDatHouse, sellDatHouseFromDB);
                ctx.Sellers.Remove(sellDatHouse);
                ctx.SaveChanges();
            }
        }
        [TestMethod]
        public void UpdateTest()
        {
            using (var context = new SystemContext())
            {
                //Create properties that are part of seller.
                List<Property> propertyList = new List<Property>();
                //Create the user itself
                Seller johnDoe = new Seller() { Name = "John Doe", Address = "Sofiendalsvej 60", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985", ZipCode = "9000", Properties = propertyList };
                //Save it to the database
                context.Sellers.Add(johnDoe);
                context.SaveChanges();
                //Change the seller:
                johnDoe.Name = "Mads";
                context.SaveChanges();
                Seller dbSeller = context.Sellers.Where(x => x.Name == "Mads").Single();

                //Test the assertion
                Assert.AreNotEqual("John Doe", dbSeller.Name);
                context.Sellers.Remove(johnDoe);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void DeleteTest()
        {
            using (var context = new SystemContext())
            {
                //Create properties that are part of seller.
                List<Property> propertyList = new List<Property>();
                //Create the user itself
                Seller johnDoe = new Seller() { Name = "John Doe", Address = "Sofiendalsvej 60", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985", Properties = propertyList, ZipCode = "9000" };

                //Save it to the database
                context.Sellers.Add(johnDoe);
                context.SaveChanges();

                //Delete it again
                context.Sellers.Remove(johnDoe);
                context.SaveChanges();

                //Try to retrieve the deleted seller again, and assert it is null.
                Seller dbSeller = context.Sellers.Where(x => x.Name == "John Doe").SingleOrDefault();
                Assert.AreEqual(null, dbSeller);
            }
        }
    }
}
