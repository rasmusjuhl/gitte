/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * I den pågældende klasse findes der Unit Tests af ControlLayerets UserController.
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

    public class UserTest
    {
        private UserController uCtr;
        [TestInitialize]
        public void Initialize()
        {
            uCtr = new UserController();
        }

        [TestMethod]
        public void CreateTest()
        {
            //Create the user itself
            User johnDoe = new User() { Name = "John Doe", Address = "Sofiendalsvej 60", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };

            //Save it to the database and get amount of properties in db before and after save
            int CountDB = uCtr.GetAllUsers().ToList().Count;
            uCtr.InsertUser(johnDoe);
            int CountDBAfter = uCtr.GetAllUsers().ToList().Count;

            //Compare Properties. Maybe use conditions other than Adress?
            Assert.AreEqual<int>(CountDBAfter, CountDB + 1);
            uCtr.DeleteUser(johnDoe);
        }
        [TestMethod]
        public void ReadTest()
        {
            //No properties does need to be created before the property itself 
            //Create the property itself 
            User johnDoe = new User() { Name = "John Doe", Address = "Sofiendalsvej 60", ZipCode = "9000", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };

            //Save it to the database 
            uCtr.InsertUser(johnDoe);

            //Get property from database and assert not null
            Assert.IsNotNull(uCtr.GetUserByPhone("51203985"));
            uCtr.DeleteUser(johnDoe);
        }

        [TestMethod]
        public void UpdateTest()
        {
            //Create the user itself
            User johnDoe = new User() { Name = "John Doe", Address = "Sofiendalsvej 60", ZipCode = "9000", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };
            //Save it to the database
            uCtr.InsertUser(johnDoe);
            //Change the user:
            List<Appointment> appointmentList = new List<Appointment>();

            uCtr.UpdateUser(johnDoe, appointmentList, "John Doe", "Sofiendalsvej 60", "9000", "112", "51203985", "john@doe.com", "Her skal stå noget");

            //Test the assertion
            Assert.IsNotNull(uCtr.GetUserByPhone("112"));
            uCtr.DeleteUser(johnDoe);
        }
        [TestMethod]
        public void DeleteTest()
        {
            //Create properties that are part of user.
            //Create the user itself
            User johnDoe = new User() { Name = "John Doe", Address = "Sofiendalsvej 60", ZipCode = "9000", Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };

            //Save it to the database
            uCtr.InsertUser(johnDoe);


            //Delete it again
            uCtr.DeleteUser(johnDoe);

            //Try to retrieve the deleted user again, and assert it is null.
            User u = uCtr.GetUserByPhone(johnDoe.Phone);
            Assert.IsNull(u);
        }
    }
}
