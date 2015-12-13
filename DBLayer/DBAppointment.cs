/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * "DBLayer" har ansvaret for at tilgå databasen med de informationer, som brugeren af systemet ønsker at sende med. DBLaget har ansvaret
 * for, igennem systemcontext at oprette en forbindelse til databasen i forbindelse med Entity Framework og foretage de ønskede ændringer.
 * Selve databasen bliver oprettet af Entity Framework i samarbejde med de modelklasser vi har i "ModelLayer".
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;

namespace DBLayer
{
    public class DBAppointment
    {
        public DBAppointment()
        {

        }

        public void InsertAppointment(Appointment appointment, Buyer buyer, Seller seller)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Appointments.Add(appointment);
                if (buyer != null)
                {
                    ctx.Buyers.Attach(buyer);
                    appointment.Buyer = buyer;
                }
                if (seller != null)
                {
                    ctx.Sellers.Attach(seller);
                    appointment.Seller = seller;
                }
                ctx.SaveChanges();
            }
        }

        public List<Appointment> GetAppointment(DateTime date)
        {
            List<Appointment> appointments;
            using (var ctx = new SystemContext())
            {
                appointments = ctx.Appointments.Where(a => a.Date == date).ToList();
            }
            return appointments;
        }

        public List<Appointment> GetAllAppointments()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Appointments.Include("Buyer").Include("Seller").ToList();
            }
        }

        public void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime,
            string category, string descricption, string status)
        {
            appointment.Date = date;
            appointment.StarTime = StartTime;
            appointment.EndTime = EndTime;
            appointment.Category = category;
            appointment.Description = descricption;
            appointment.Status = status;

            using (var ctx = new SystemContext())
            {
                ctx.Entry(appointment).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteAppointment(Appointment appointment)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Appointments.Attach(appointment);
                ctx.Appointments.Remove(appointment);
                ctx.SaveChanges();
            }
        }
    }
}
