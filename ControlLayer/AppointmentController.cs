using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelLayer;
using DBLayer;

namespace ControlLayer
{
    public class AppointmentController
    {
        private DBAppointment dbApp = new DBAppointment();
        public AppointmentController()
        {
        
        }

        public void InsertAppointment(Appointment appointment)
        {
            dbApp.InsertAppointment(appointment);
        }

        public Appointment GetAppointment(DateTime date)
        {
            return dbApp.GetAppointment(date);
        }

        public List<Appointment> GetAllAppointments()
        {
            return dbApp.GetAllAppointments();
        }

        public void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime, 
            string category, string descricption, string status, Seller seller, Buyer buyer)
        {
            dbApp.UpdateAppointment(appointment, date, StartTime, EndTime, category, descricption, status, seller, buyer);
        }

        public void DeleteAppointment(Appointment appointment)
        {
            dbApp.DeleteAppointment(appointment);
        }
    }
}
