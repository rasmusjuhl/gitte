﻿using ControlLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
{
    public class PropertyService : IPropertyService
    {
        static PropertyController pCtr = new PropertyController();
        public void InsertProperty(Property property)
        {
            pCtr.InsertProperty(property);
        }

        public Property GetPropertyByAddress(string address)
        {
            return pCtr.GetPropertyByAddress(address);
        }

        public List<Property> GetAllProperties()
        {
            return pCtr.GetAllProperties();
        }

        public void UpdateProperty(Property property, string address, Location location, string type, int rooms, int floors, double price, double propertySize, double houseSize, int constructionYear)
        {
            pCtr.UpdateProperty(property, address, location, type, rooms, floors, price, propertySize, houseSize, constructionYear);
        }

        public void DeleteProperty(Property property)
        {
            pCtr.DeleteProperty(property);
        }
    }
}