﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Property
    {
        public Property()
        {
            this.Buyers = new List<Buyer>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Type { get; set; }
        public int Rooms { get; set; }
        public int Floors { get; set; }
        public double Price { get; set; }
        public double PropertySize { get; set; }
        public double HouseSize { get; set; }
        public int ConstructionYear { get; set; }
        public ICollection<Buyer> Buyers { get; set; }

        
    }
}
