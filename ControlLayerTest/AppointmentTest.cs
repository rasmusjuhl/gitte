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
    public class AppointmentTest
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
                //Creating properties for the Appointment
                DateTime date = DateTime.Today;
                DateTime meetingStart = DateTime.Now;
                DateTime meetingEnd = DateTime.Now.AddHours(2);
                //Create the Appointment itself 
                Appointment testAppointment = new Appointment() { Date = date, StarTime = meetingStart, EndTime = meetingEnd, Category = "Sælgermøde", Description = "Test for at finde en appointment", Status = "Status", UserID = 1};
                //Save it to the database
                context.Appointments.Add(testAppointment);
                context.SaveChanges();

                //Compare Properties. Maybe use conditions other than Adress?
                Appointment testAppointmentDB = context.Appointments.Where(x => x.Description == "Test for at finde en appointment").Single();
                Assert.AreEqual<Appointment>(testAppointment, testAppointmentDB);
                context.Appointments.Remove(testAppointment);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void UpdateTest()
        {
            using (var context = new SystemContext())
            {
                ///Creating properties for the Appointment
                DateTime date = DateTime.Today;
                DateTime meetingStart = DateTime.Now;
                DateTime meetingEnd = DateTime.Now.AddHours(2);
                //Create the Appointment itself 
                Appointment testAppointment = new Appointment() { Date = date, StarTime = meetingStart, EndTime = meetingEnd, Category = "Sælgermøde", Description = "Test for at finde en appointment", Status = "Status", UserID = 1 };
                //Save it to the database
                context.Appointments.Add(testAppointment);
                context.SaveChanges();
                
                //Change the Appointment:
                Appointment testAppointmentDB = context.Appointments.Where(x => x.Description == "Test for at finde en appointment").Single();
                testAppointment.Description = "Ny beskrivelse";
                context.SaveChanges();
                
                //Test the assertion
                Assert.AreNotEqual(testAppointmentDB.Description, testAppointment.Description);
                context.Appointments.Remove(testAppointment);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            using (var context = new SystemContext())
            {
                ///Creating properties for the Appointment
                DateTime date = DateTime.Today;
                DateTime meetingStart = DateTime.Now;
                DateTime meetingEnd = DateTime.Now.AddHours(2);
                //Create the Appointment itself 
                Appointment testAppointment = new Appointment() { Date = date, StarTime = meetingStart, EndTime = meetingEnd, Category = "Sælgermøde", Description = "Test for at finde en appointment", Status = "Status", UserID = 1 };
                //Save it to the database
                context.Appointments.Add(testAppointment);
                context.SaveChanges();

                //Delete it again
                context.Appointments.Remove(testAppointment);
                context.SaveChanges();

                //Try to retrieve the deleted Appointment again, and assert it is null.
                Appointment testAppointmentDB = context.Appointments.Where(x => x.Description == "Test for at finde en appointment").SingleOrDefault();
                Assert.AreEqual(null, testAppointmentDB);
            }
        }
    }
}
