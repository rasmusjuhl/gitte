using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        [StringLength(450)]
        [Required]
        [Index(IsUnique = true)]
        public string Phone { get; set; }
        [StringLength(450)]
        [Required]
        [Index(IsUnique = true)]
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Misc { get; set; }
        

        
    }
}
