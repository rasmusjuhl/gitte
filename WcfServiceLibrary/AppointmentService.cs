using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using ControlLayer;

namespace WcfServiceLibrary
{
    public class AppointmentService : IAppointmentService
    {
        static AppointmentController aCtr = new AppointmentController();
        public void InsertAppointment(Appointment appointment)
        {
            aCtr.InsertAppointment(appointment);
        }

        public Appointment GetAppointment(DateTime date)
        {
            return aCtr.GetAppointment(date);
        }

        public List<Appointment> GetAllAppointments()
        {
            return aCtr.GetAllAppointments();
        }

        public void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime, string category, string descricption, string status, Seller seller, Buyer buyer)
        {
            aCtr.UpdateAppointment(appointment, date, StartTime, EndTime, category, descricption, status, seller, buyer);
        }

        public void DeleteAppointment(Appointment appointment)
        {
            aCtr.DeleteAppointment(appointment);
        }
    }
}
