﻿/* 
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
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class Appointment
    {
        public int Id { get; set; }
        [Required, Index("DateStartAndUserID", 1, IsUnique = true)]
        public DateTime Date { get; set; }
        [Required, Index("DateStartAndUserID", 2, IsUnique = true)]
        public DateTime StarTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
        [Required, Index("DateStartAndUserID", 3, IsUnique = true)]
        public int UserID { get; set; }

    }
}
