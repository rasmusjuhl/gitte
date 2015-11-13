using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
    }
}
