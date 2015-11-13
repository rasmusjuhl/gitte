using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Buyer : Person
    {
        public string EstateType { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public double LotSizeMin { get; set; }
        public double LotSizeMax { get; set; }
        public double ProbertySizeMin { get; set; }
        public double ProbertySizeMax { get; set; }
        public double DesiredRoomsMin { get; set; }
        public double DesiredRoomsMax { get; set; }
        public List<Location> DesiredLocations { get; set; }
        public string OtherPref { get; set; }
        public Boolean ContactAllowedByBoligOne { get; set; }
        public Boolean ContactAllowedByReal { get; set; }
        public Boolean AllowedEmailSpam { get; set; }
        public Boolean InRKI { get; set; }
        public Boolean BuyerApproved { get; set; }
        public string Bank { get; set; }
        public Boolean OwnesHouse { get; set; }
        public Boolean LivesForRent { get; set; }

        public Buyer(string name, string adress, Location location, string phone, string mobil, string email, string misc,
            string estateType, double minPrice, double maxPrice, double lotSizeMin, double lotSizeMax, double probertySizeMin, double probertySizeMax, double desiredRoomsMin, double desiredRoomsMax, List<Location> desiredLocations, string otherPref, Boolean contactAllowedByBoligOne, Boolean contactAllowedByReal, Boolean allowedEmailSpam, Boolean inRKI, Boolean buyerApproved, string bank, Boolean ownesHouse, Boolean livesForRent)
            : base(name, adress, location, phone, mobil, email, misc)
        {
            this.EstateType = estateType;
            this.MinPrice = minPrice;
            this.MaxPrice = maxPrice;
            this.LotSizeMin = lotSizeMin;
            this.LotSizeMax = lotSizeMax;
            this.ProbertySizeMin = probertySizeMin;
            this.ProbertySizeMax = probertySizeMax;
            this.DesiredRoomsMin = desiredRoomsMin;
            this.DesiredRoomsMax = desiredRoomsMax;
            this.DesiredLocations = desiredLocations;
            this.OtherPref = otherPref;
            this.ContactAllowedByBoligOne = contactAllowedByBoligOne;
            this.ContactAllowedByReal = contactAllowedByReal;
            this.AllowedEmailSpam = allowedEmailSpam;
            this.InRKI = inRKI;
            this.BuyerApproved = buyerApproved;
            this.Bank = bank;
            this.OwnesHouse = ownesHouse;
            this.LivesForRent = livesForRent;
        }
    }
}
