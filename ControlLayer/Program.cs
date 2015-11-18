using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DAL;

namespace ControlLayer
{
    public class Program
    {
        private static LocationController lc = new LocationController();
        private static AppointmentController ac = new AppointmentController();
        static void Main(string[] args)
        {
            var db = new SystemContext();
            Console.WriteLine(db.Database.Connection.ConnectionString);
            Console.ReadLine();
        }
    }
}
