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

    public class UserTest
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
                //Create properties that are part of user.
                Appointment appointment = new Appointment();
                Appointment appointment2 = new Appointment();
                List<Appointment> appointmentList = new List<Appointment>();
                Location location = new Location();

                //Create the user itself
                User johnDoe = new User() { Name = "John Doe", Address = "Sofiendalsvej 60", Appointments = appointmentList, Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };
                //Save it to the database
                context.Users.Add(johnDoe);
                context.SaveChanges();

                //Compare users. Maybe use conditions other than name?
                User johnDoeFromDB = context.Users.Where(x => x.Name == "John Doe").Single();
                Assert.AreEqual<User>(johnDoe, johnDoeFromDB);
                context.Users.Remove(johnDoe);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void UpdateTest()
        {
            using (var context = new SystemContext())
            {
                //Create properties that are part of user.
                Appointment appointment = new Appointment();
                Appointment appointment2 = new Appointment();
                List<Appointment> appointmentList = new List<Appointment>();
                Location location = new Location();
                //Create the user itself
                User johnDoe = new User() { Name = "John Doe", Address = "Sofiendalsvej 60", Appointments = appointmentList, Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };
                //Save it to the database
                context.Users.Add(johnDoe);
                context.SaveChanges();
                //Change the user:
                johnDoe.Name = "Mads";
                context.SaveChanges();
                User dbUser = context.Users.Where(x => x.Name == "Mads").Single();

                //Test the assertion
                Assert.AreNotEqual("John Doe", dbUser.Name);
                context.Users.Remove(johnDoe);
                context.SaveChanges();
            }
        }
        [TestMethod]
        public void DeleteTest()
        {
            using (var context = new SystemContext())
            {
                //Create properties that are part of user.
                Appointment appointment = new Appointment();
                Appointment appointment2 = new Appointment();
                List<Appointment> appointmentList = new List<Appointment>();
                Location location = new Location();
                //Create the user itself
                User johnDoe = new User() { Name = "John Doe", Address = "Sofiendalsvej 60", Appointments = appointmentList, Email = "john@doe.com", Misc = "Her skal stå noget", Mobile = "51203985", Phone = "51203985" };
                
                //Save it to the database
                context.Users.Add(johnDoe);
                context.SaveChanges();
                
                //Delete it again
                context.Users.Remove(johnDoe);
                context.SaveChanges();
                
                //Try to retrieve the deleted user again, and assert it is null.
                User dbUser = context.Users.Where(x => x.Name == "John Doe").SingleOrDefault();
                Assert.AreEqual(null, dbUser);
            }
        }
    }
}
