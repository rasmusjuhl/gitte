using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class User : Person
    {
        public int Id { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
