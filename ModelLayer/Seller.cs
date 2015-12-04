using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace ModelLayer
{
    public class Seller : Person
    {
        public int Id { get; set; }
        public List<Property> Properties { get; set; }
       

    }
}
