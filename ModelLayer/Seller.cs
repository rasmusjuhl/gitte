using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Seller : Person
    {
        public int Id { get; set; }
        public List<Property> Properties { get; set; }
       

    }
}
