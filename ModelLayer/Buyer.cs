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
using System.Data.Entity;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer
{
    public class Buyer : Person
    {
        public Buyer()
        {
            this.Locations = new List<Location>();
            this.Properties = new List<Property>();
        }

        public int Id { get; set; }
        public string EstateType { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public double LotSizeMin { get; set; }
        public double LotSizeMax { get; set; }
        public double ProbertySizeMin { get; set; }
        public double ProbertySizeMax { get; set; }
        public double DesiredRoomsMin { get; set; }
        public double DesiredRoomsMax { get; set; }
        public string OtherPref { get; set; }
        public Boolean ContactAllowedByBoligOne { get; set; }
        public Boolean ContactAllowedByReal { get; set; }
        public Boolean AllowedEmailSpam { get; set; }
        public Boolean InRKI { get; set; }
        public Boolean BuyerApproved { get; set; }
        public string Bank { get; set; }
        public double ApprovedAmount { get; set; }
        public Boolean OwnesHouse { get; set; }
        public Boolean LivesForRent { get; set; }
        public ICollection<Property> Properties { get; set; }
        public ICollection<Location> Locations { get; set; }

        
    }
}
