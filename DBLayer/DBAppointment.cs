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

        public void InsertAppointment(Appointment appointment)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Appointments.Add(appointment);
                ctx.SaveChanges();
            }
        }

        public Appointment GetAppointment(DateTime date)
        {
            Appointment appointment;
            using (var ctx = new SystemContext())
            {
                appointment = ctx.Appointments.Where(a => a.Date == date).Single();
            }
            return appointment;
        }

        public List<Appointment> GetAllAppointments()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Appointments.ToList();
            }
        }

        public void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime,
            string category, string descricption, string status, Seller seller, Buyer buyer)
        {
            appointment.Date = date;
            appointment.StarTime = StartTime;
            appointment.EndTime = EndTime;
            appointment.Category = category;
            appointment.Description = descricption;
            appointment.Status = status;
            appointment.Seller = seller;
            appointment.Buyer = buyer;

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
