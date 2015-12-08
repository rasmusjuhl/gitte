using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLayer;
using ModelLayer.DAL;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using ControlLayer;

namespace ControlLayerTest
{
    [TestClass]
    public class SellerTest
    {
        private SellerController sCtr;
        [TestInitialize]
        public void Initialize()
        {
            sCtr = new SellerController();
        }

        [TestMethod]
        public void CreateTest()
        {
            //Create necessary list for seller.
            List<Property> propertyList = new List<Property>();

            //Create the seller itself.
            Seller sellDatHouse = new Seller() { Name = "Mr. Sell D. House", Address = "Sofiendalsvej 60", Email = "sell@house.com", Misc = "Han vil virkelig gerne have sit hus solgt", Mobile = "40528283", Phone = "40528283", ZipCode = "9000", Properties = propertyList };

            //Save it to the database
            int CountDB = sCtr.GetAllSellers().ToList().Count;
            sCtr.InsertSeller(sellDatHouse);
            int CountDBAfter = sCtr.GetAllSellers().ToList().Count;

            //Compare sellers.
            Assert.AreEqual<int>(CountDBAfter, CountDB + 1);
            sCtr.DeleteSeller(sellDatHouse);
        }

        [TestMethod]
        public void ReadTest()
        {
            //Create necessary list for seller.
            List<Property> propertyList = new List<Property>();

            //Create the seller itself.
            Seller sellDatHouse = new Seller() { Name = "Mr. Sell D. House", Address = "Sofiendalsvej 60", Email = "sell@house.com", Misc = "Han vil virkelig gerne have sit hus solgt", Mobile = "40528283", Phone = "40528283", ZipCode = "9000", Properties = propertyList };

            //Save it to the database
            sCtr.InsertSeller(sellDatHouse);

            //Compare sellers.
            Assert.IsNotNull(sCtr.GetSellerByPhone("40528283"));
            sCtr.DeleteSeller(sellDatHouse);
        }

        [TestMethod]
        public void UpdateTest()
        {
            //Create necessary list for seller.
            List<Property> propertyList = new List<Property>();

            //Create the seller itself.
            Seller sellDatHouse = new Seller() { Name = "Mr. Sell D. House", Address = "Sofiendalsvej 60", Email = "sell@house.com", Misc = "Han vil virkelig gerne have sit hus solgt", Mobile = "40528283", Phone = "40528283", ZipCode = "9000", Properties = propertyList };

            //Save it to the database
            sCtr.InsertSeller(sellDatHouse);

            //Change the seller:
            sCtr.UpdateSeller(sellDatHouse, propertyList, sellDatHouse.Name, sellDatHouse.Address, sellDatHouse.ZipCode, "112", sellDatHouse.Mobile, sellDatHouse.Email, sellDatHouse.Misc);

            //Test the assertion
            Assert.IsNotNull(sCtr.GetSellerByPhone("112"));
            sCtr.DeleteSeller(sellDatHouse);
        }

        [TestMethod]
        public void DeleteTest()
        {
            //Create necessary list for seller.
            List<Property> propertyList = new List<Property>();

            //Create the seller itself.
            Seller sellDatHouse = new Seller() { Name = "Mr. Sell D. House", Address = "Sofiendalsvej 60", Email = "sell@house.com", Misc = "Han vil virkelig gerne have sit hus solgt", Mobile = "40528283", Phone = "40528283", ZipCode = "9000", Properties = propertyList };

            //Save it to the database
            sCtr.InsertSeller(sellDatHouse);

            //Delete it again
            sCtr.DeleteSeller(sellDatHouse);

            //Try to retrieve the deleted seller again, and assert it is null.
            Seller sellDatHouseNew = sCtr.GetSellerByPhone(sellDatHouse.Mobile);
            Assert.IsNull(sellDatHouseNew);
        }
    }
}
