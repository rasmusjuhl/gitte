using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;

namespace WcfServiceLib
{
    public class AppointmentService : IAppointmentService
    {
        static AppointmentController aCtr = new AppointmentController();

        public void InsertAppointment(ModelLayer.Appointment appointment)
        {
            aCtr.InsertAppointment(appointment);
        }

        public ModelLayer.Appointment GetAppointment(DateTime date)
        {
           return aCtr.GetAppointment(date);
        }

        public List<ModelLayer.Appointment> GetAllAppointments()
        {
            return aCtr.GetAllAppointments();
        }

        public void UpdateAppointment(ModelLayer.Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime, string category, string descricption, string status, ModelLayer.Seller seller, ModelLayer.Buyer buyer)
        {
            aCtr.UpdateAppointment(appointment, date, StartTime, EndTime, category, descricption, status, seller, buyer);
        }

        public void DeleteAppointment(ModelLayer.Appointment appointment)
        {
            aCtr.DeleteAppointment(appointment);
        }
    }
}
