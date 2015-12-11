/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * "ModelLayer" indeholder de forskellige modeller, som skal bearbejdes og bruges i systemet. Da modelklasserne også anvendes af
 * Entity Framework, indeholder disse modelklasser også informationer om de forudsætninger den enkelte property skal overholde når 
 * der skal kommunikeres med databasen. (uniqueness, nulleable etc.)
*/
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
