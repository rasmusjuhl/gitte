﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;

namespace DBLayer
{
    public class DBLocation
    {
        public DBLocation()
        {

        }

        public void InsertLocation(Location location)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Locations.Add(location);
                ctx.SaveChanges();
            }
        }

        public Location GetLocation(string zipCode)
        {
            Location loc;
            using (var ctx = new SystemContext())
            {
                loc = ctx.Locations.Where(x => x.ZipCode == zipCode).Single();
            }
            return loc;
        }
        public List<Location> GetLocationsByCity(string city)
        {
            using (var ctx = new SystemContext())
            {
                var loc = ctx.Locations.Where(l => l.City.Contains(city));
                return loc.ToList();
            }
        }

        public List<Location> GetAllLocations()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Locations.ToList();
            }
        }

        public void UpdateLocation(Location loc, string zipCode, string city)
        {
            loc.ZipCode = zipCode;
            loc.City = city;
            using (var ctx = new SystemContext())
            {
                ctx.Entry(loc).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteLocation(Location loc)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Locations.Attach(loc);
                ctx.Locations.Remove(loc);
                ctx.SaveChanges();
            }
        }
    }
}