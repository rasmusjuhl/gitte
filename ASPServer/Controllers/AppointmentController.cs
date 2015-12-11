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
    }
}