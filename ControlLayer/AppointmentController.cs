/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * "ControlLayer" er det lag i programmet, som er bindeledet mellem 
 * DatabaseAccessLaget(kommunikation til database) og WCFServiceLaget(kommunikation ud) 
*/
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

        public void InsertAppointment(Appointment appointment, Buyer buyer, Seller seller)
        {
            dbApp.InsertAppointment(appointment, buyer, seller);
        }

        public List<Appointment> GetAppointment(DateTime date)
        {
            return dbApp.GetAppointment(date);
        }

        public List<Appointment> GetAllAppointments()
        {
            return dbApp.GetAllAppointments();
        }

        public void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime, 
            string category, string descricption, string status)
        {
            dbApp.UpdateAppointment(appointment, date, StartTime, EndTime, category, descricption, status);
        }

        public void DeleteAppointment(Appointment appointment)
        {
            dbApp.DeleteAppointment(appointment);
        }
    }
}
