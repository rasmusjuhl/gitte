using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Location Location { get; set; }
        public string Phone { get; set; }
        public string Mobil { get; set; }
        public string Email { get; set; }
        public string Misc { get; set; }
        

        public Person(string name, string address, Location location, string phone, string mobil, string email, string misc)
        {
            this.Name = name;
            this.Address = address;
            this.Location = location;
            this.Phone = phone;
            this.Mobil = mobil;
            this.Email = email;
            this.Misc = misc;
        }
    }
}
