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
    public class Property
    {
        public Property()
        {
            this.Buyers = new List<Buyer>();
        }

        public int Id { get; set; }
        [StringLength(450)]
        [Index("AddresseAndZipCode", 1, IsUnique = true)]
        public string Address { get; set; }
        [StringLength(450)]
        [Index("AddresseAndZipCode", 2, IsUnique = true)]
        public string ZipCode { get; set; }
        public string Type { get; set; }
        public int Rooms { get; set; }
        public int Floors { get; set; }
        public double Price { get; set; }
        public double PropertySize { get; set; }
        public double HouseSize { get; set; }
        public int ConstructionYear { get; set; }
        public int SellerID { get; set; }
        public ICollection<Buyer> Buyers { get; set; }

        
    }
}
