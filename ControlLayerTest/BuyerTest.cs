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

    public class BuyerTest
    {
        private BuyerController bCtr;
        [TestInitialize]
        public void Initialize()
        {
            bCtr = new BuyerController();
        }

        [TestMethod]
        public void CreateTest()
        {
            //Create the user itself
            Buyer johnDoe = new Buyer() { Name = "John Doe", Address = "Sofiendalsvej 60", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };

            //Save it to the database and get amount of properties in db before and after save
            int CountDB = bCtr.GetAllBuyers().ToList().Count;
            bCtr.InsertBuyer(johnDoe);
            int CountDBAfter = bCtr.GetAllBuyers().ToList().Count;
            //Compare Properties. Maybe use conditions other than Adress?
            Assert.AreEqual<int>(CountDBAfter, CountDB + 1);
            bCtr.DeleteBuyer(johnDoe);
        }
        [TestMethod]
        public void ReadTest()
        {
            //No properties does need to be created before the property itself 
            //Create the property itself 
            Buyer johnDoe = new Buyer() { Name = "John Doe", Address = "Sofiendalsvej 60", ZipCode = "9000", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };

            //Save it to the database 
            bCtr.InsertBuyer(johnDoe);

            //Get property from database and assert not null
            Assert.IsNotNull(bCtr.GetBuyerByPhone("51203985"));
            bCtr.DeleteBuyer(johnDoe);
        }

        [TestMethod]
        public void UpdateTest()
        {
            //Create the user itself
            List<Location> locations = new List<Location>();
          
            Buyer johnDoe = new Buyer() { Name = "John Doe", Address = "Sofiendalsvej 60", ZipCode = "9000", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985", Locations = locations };
            //Save it to the database
            bCtr.InsertBuyer(johnDoe);
            //Change the user:
            List<Property> properties = new List<Property>();
            bCtr.UpdateBuyer(johnDoe, properties, johnDoe.Name, johnDoe.Address, johnDoe.ZipCode, "112", johnDoe.Mobile, johnDoe.Email, johnDoe.Misc, johnDoe.EstateType, johnDoe.MinPrice, johnDoe.MaxPrice, johnDoe.LotSizeMin, johnDoe.LotSizeMax, johnDoe.ProbertySizeMin, johnDoe.ProbertySizeMax, johnDoe.DesiredRoomsMin, johnDoe.DesiredRoomsMax,
                johnDoe.Locations.ToList(), johnDoe.OtherPref, johnDoe.ContactAllowedByBoligOne, johnDoe.ContactAllowedByReal, johnDoe.AllowedEmailSpam, johnDoe.InRKI, johnDoe.BuyerApproved, johnDoe.Bank, johnDoe.OwnesHouse, johnDoe.LivesForRent);

            //Test the assertion

            Assert.IsNotNull(bCtr.GetBuyerByPhone("112"));
            bCtr.DeleteBuyer(johnDoe);
        }
        [TestMethod]
        public void DeleteTest()
        {
            //Create properties that are part of user.
            //Create the user itself
            Buyer johnDoe = new Buyer() { Name = "John Doe", Address = "Sofiendalsvej 60", ZipCode = "9000", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };

            //Save it to the database
            bCtr.InsertBuyer(johnDoe);


            //Delete it again
            bCtr.DeleteBuyer(johnDoe);

            //Try to retrieve the deleted user again, and assert it is null.
            Buyer b = bCtr.GetBuyerByPhone(johnDoe.Phone);
            Assert.IsNull(b);
        }
    }
}
