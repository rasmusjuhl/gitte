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
    public class AppointmentTest
    {
        private AppointmentController aCtr;
        [TestInitialize]
        public void Initialize()
        {
            aCtr = new AppointmentController();
        }

        [TestMethod]
        public void CreateTest()
        {
            //Creating properties for the Appointment
            DateTime date = DateTime.Today;
            DateTime meetingStart = DateTime.Now;
            DateTime meetingEnd = DateTime.Now.AddHours(2);
            
            //Create the Appointment itself 
            Appointment testAppointment = new Appointment() { Date = date, StarTime = meetingStart, EndTime = meetingEnd, Category = "Sælgermøde", Description = "Test for at finde en appointment", Status = "Status", UserID = 1 };

            //Save it to the database
            int CountDB = aCtr.GetAllAppointments().ToList().Count;
            aCtr.InsertAppointment(testAppointment);
            int CountDBAfter = aCtr.GetAllAppointments().ToList().Count;

            //Compare Properties. Maybe use conditions other than Adress?
            Assert.AreEqual<int>(CountDBAfter, CountDB + 1);
            aCtr.DeleteAppointment(testAppointment); ;
        }

        [TestMethod]
        public void ReadTest()
        {
            //Creating properties for the Appointment
            DateTime date = DateTime.Today;
            DateTime meetingStart = DateTime.Now;
            DateTime meetingEnd = DateTime.Now.AddHours(2);
            
            //Create the Appointment itself 
            Appointment testAppointment = new Appointment() { Date = date, StarTime = meetingStart, EndTime = meetingEnd, Category = "Sælgermøde", Description = "Test for at finde en appointment", Status = "Status", UserID = 1 };

            //Save it to the database
            aCtr.InsertAppointment(testAppointment);

            //Get property from database and assert not null
            Assert.IsNotNull(aCtr.GetAppointment(date));
            aCtr.DeleteAppointment(testAppointment);
        }

        [TestMethod]
        public void UpdateTest()
        {
            //Creating properties for the Appointment
            DateTime date = DateTime.Today;
            DateTime meetingStart = DateTime.Now;
            DateTime meetingEnd = DateTime.Now.AddHours(2);
            
            //Create the Appointment itself 
            Appointment testAppointment = new Appointment() { Date = date, StarTime = meetingStart, EndTime = meetingEnd, Category = "Sælgermøde", Description = "Test for at finde en appointment", Status = "Status", UserID = 1 };

            //Save it to the database
            aCtr.InsertAppointment(testAppointment);

            //Change the Appointment:

            aCtr.UpdateAppointment(testAppointment, date, meetingStart, meetingEnd, "Ny", "Hej", "done", null, null);

            //Test the assertion
            Assert.AreNotEqual<string>("Sælgermøde", aCtr.GetAppointment(date).First().Category);
            aCtr.DeleteAppointment(testAppointment);
        }

        [TestMethod]
        public void DeleteTest()
        {
            //Creating properties for the Appointment
            DateTime date = DateTime.Today;
            DateTime meetingStart = DateTime.Now;
            DateTime meetingEnd = DateTime.Now.AddHours(2);
           
            //Create the Appointment itself 
            Appointment testAppointment = new Appointment() { Date = date, StarTime = meetingStart, EndTime = meetingEnd, Category = "Sælgermøde", Description = "Test for at finde en appointment", Status = "Status", UserID = 1 };

            //Save it to the database
            aCtr.InsertAppointment(testAppointment);

            //Delete it again
            aCtr.DeleteAppointment(testAppointment);

            //Try to retrieve the deleted Appointment again, and assert it is null.
            Appointment testAppointmentDB = aCtr.GetAppointment(date).SingleOrDefault();
            Assert.AreEqual(null, testAppointmentDB);
        }
    }
}
