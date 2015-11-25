using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using ModelLayer.DAL;

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

        //public User GetUserByPhone(string phone)
        //{
        //    User user;
        //    using (var ctx = new SystemContext())
        //    {
        //        user = ctx.Users.Where(x => x.Phone == phone).Single();
        //    }
        //    user.Location = dbLoc.GetLocation(user.ZipCode);
        //    return user;
        //}

        //public List<User> GetAllUsers()
        //{
        //    List<User> users;
        //    using (var ctx = new SystemContext())
        //    {
        //        users = ctx.Users.ToList();
        //    }
        //    foreach (User user in users)
        //    {
        //        user.Location = dbLoc.GetLocation(user.ZipCode);
        //    }
        //    return users;
        //}

        public User GetUserByPhone(string phone)
        {
            User user;
            using (var ctx = new SystemContext())
            {
                user = ctx.Users.Where(x => x.Phone == phone).Single();
            }
            return user;
        }

        public List<User> GetAllUsers()
        {
            List<User> users;
            using (var ctx = new SystemContext())
            {
                users = ctx.Users.ToList();
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
