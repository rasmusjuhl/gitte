using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;
using System.Data.Entity;

namespace DBLayer
{
    public class DBUser
    {
        private DBLocation dbLoc = new DBLocation();

        public DBUser()
        {
                
        }

        public void InsertUser(User user)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }

        public User GetUserByPhone(string phone)
        {
            User user;
            using (var ctx = new SystemContext())
            {
                user = ctx.Users.Where(x => x.Phone == phone).SingleOrDefault();
            }
            return user;
        }

        public List<User> GetAllUsers()
        {
            List<User> users;
            using (var ctx = new SystemContext())
            {
                users = ctx.Users.Include(x => x.Appointments)
                                 .Include(x => x.Appointments.Select(y => y.Buyer))
                                 .Include(x => x.Appointments.Select(y => y.Seller)).ToList();
            }
            return users;
        }

        public void UpdateUser(User user, List<Appointment> appointments, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            user.Name = name;
            user.Appointments = appointments;
            user.Address = address;
            user.ZipCode = zipCode;
            user.Phone = phone;
            user.Mobile = mobil;
            user.Email = email;
            user.Misc = misc;
            using (var ctx = new SystemContext())
            {
                ctx.Entry(user).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void DeleteUser(User user)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Users.Attach(user);
                ctx.Users.Remove(user);
                ctx.SaveChanges();
            }
        }

    }
}
