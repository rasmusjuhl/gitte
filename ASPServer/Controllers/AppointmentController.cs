using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPServer.ServiceReference;

namespace ASPServer.Controllers
{
    public class AppointmentController : Controller
    {
        static IService iService = new ServiceClient();
        // GET: Appointment
        public ActionResult Index()
        {
            List<Appointment> appointments = iService.GetAllAppointments();
            return View(appointments);
        }

        public ActionResult Details(int id)
        {
            /*Get all appointments again, and then find the one we need based on ID.
             * We do this here instead of implementing GetBuyerById(int id) becase of limitations in EF
            */
            List<Appointment> appointments = iService.GetAllAppointments();
            Appointment appointment = appointments.Find(listappointment => listappointment.Id == id);

            //Make single appointment available to view
            return View(appointment);
        }
    }
}