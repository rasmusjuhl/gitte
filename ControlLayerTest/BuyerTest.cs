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

    public class BuyerTest
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
                //Create properties that are part of buyer.
                List<Location> locationList = new List<Location>();
                List<Property> propertyList = new List<Property>();

                //Create the buyer itself
                Buyer johnDoe = new Buyer() { Name = "John Doe", Address = "Sofiendalsvej 60", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985", ZipCode = "9000", AllowedEmailSpam = false, Bank = "Nordea", BuyerApproved = true, ContactAllowedByBoligOne = true, ContactAllowedByReal = true, DesiredRoomsMax = 6, DesiredRoomsMin = 4, EstateType = "House", InRKI = false, LivesForRent = false, Locations = locationList, LotSizeMax = 400, LotSizeMin = 300, MaxPrice = 2500000, MinPrice = 2000000, OtherPref = "Ingen naboer. Hader mennesker", OwnesHouse = true, ProbertySizeMax = 250, ProbertySizeMin = 200, Properties = propertyList };
                //Save it to the database
                context.Buyers.Add(johnDoe);
                context.SaveChanges();

                //Compare buyers. Maybe use conditions other than name?
                Buyer johnDoeFromDB = context.Buyers.Where(x => x.Name == "John Doe").Single();
                Assert.AreEqual<Buyer>(johnDoe, johnDoeFromDB);
                context.Buyers.Remove(johnDoe);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void UpdateTest()
        {
            using (var context = new SystemContext())
            {
                //Create properties that are part of buyer.
                List<Location> locationList = new List<Location>();
                List<Property> propertyList = new List<Property>();
                //Create the buyer itself
                Buyer johnDoe = new Buyer() { Name = "John Doe", Address = "Sofiendalsvej 60", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985", ZipCode = "9000", AllowedEmailSpam = false, Bank = "Nordea", BuyerApproved = true, ContactAllowedByBoligOne = true, ContactAllowedByReal = true, DesiredRoomsMax = 6, DesiredRoomsMin = 4, EstateType = "House", InRKI = false, LivesForRent = false, Locations = locationList, LotSizeMax = 400, LotSizeMin = 300, MaxPrice = 2500000, MinPrice = 2000000, OtherPref = "Ingen naboer. Hader mennesker", OwnesHouse = true, ProbertySizeMax = 250, ProbertySizeMin = 200, Properties = propertyList };
                //Save it to the database
                context.Buyers.Add(johnDoe);
                context.SaveChanges();
                //Change the buyer:
                johnDoe.Name = "Mads";
                context.SaveChanges();
                Buyer dbBuyer = context.Buyers.Where(x => x.Name == "Mads").Single();

                //Test the assertion
                Assert.AreNotEqual("John Doe", dbBuyer.Name);
                context.Buyers.Remove(johnDoe);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void DeleteTest()
        {
            using (var context = new SystemContext())
            {
                //Create properties that are part of buyer.
                List<Location> locationList = new List<Location>();
                List<Property> propertyList = new List<Property>();
                //Create the buyer itself
                Buyer johnDoe = new Buyer() { Name = "John Doe", Address = "Sofiendalsvej 60", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985", ZipCode = "9000", AllowedEmailSpam = false, Bank = "Nordea", BuyerApproved = true, ContactAllowedByBoligOne = true, ContactAllowedByReal = true, DesiredRoomsMax = 6, DesiredRoomsMin = 4, EstateType = "House", InRKI = false, LivesForRent = false, Locations = locationList, LotSizeMax = 400, LotSizeMin = 300, MaxPrice = 2500000, MinPrice = 2000000, OtherPref = "Ingen naboer. Hader mennesker", OwnesHouse = true, ProbertySizeMax = 250, ProbertySizeMin = 200, Properties = propertyList };

                //Save it to the database
                context.Buyers.Add(johnDoe);
                context.SaveChanges();

                //Delete it again
                context.Buyers.Remove(johnDoe);
                context.SaveChanges();

                //Try to retrieve the deleted buyer again, and assert it is null.
                Buyer dbBuyer = context.Buyers.Where(x => x.Name == "John Doe").SingleOrDefault();
                Assert.AreEqual(null, dbBuyer);
            }
        }
    }
}
