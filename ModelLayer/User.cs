using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class User : Person
    {
        public int Id { get; set; }
        public User(int id, string name, string address, Location location, string phone, string mobil, string email, string misc)
            : base(name, address, location, phone, mobil, email, misc)
        {
            this.Id = id;
        }

    }
}
