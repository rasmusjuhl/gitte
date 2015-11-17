using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;

namespace ControlLayer
{
    public class UserController
    {
        public UserController()
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
        public User GetUser(string phone)
        {
            List<User> user;
            using (var ctx = new SystemContext())
            {
                var res = from x in ctx.Users
                          where x.Phone == phone
                          select x;
                user = res.ToList();
            }
            return user.First();
        }

        public List<User> GetAllUsers()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users.ToList();
            }
        }
        
        public void UpdateUser(User user, List<Appointment> appointments, string name, string address, Location location, string phone, string mobil, string email, string misc)
        {
            user.Name = name;
            user.Appointments = appointments;
            user.Address = address;
            user.Location = location;
            user.Phone = phone;
            user.Mobil = mobil;
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
