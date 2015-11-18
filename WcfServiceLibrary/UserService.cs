using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;
using ModelLayer;

namespace WcfServiceLibrary
{
    public class UserService : IUserService
    {
        static UserController uCtr = new UserController();

        public void InsertUser(User user)
        {
            uCtr.InsertUser(user);
        }

        public User GetUserUserByPhone(string phone)
        {
            return uCtr.GetUserByPhone(phone);
        }

        public List<User> GetAllUsers()
        {
            return uCtr.GetAllUsers();
        }

        public void UpdateUser(User user, List<Appointment> appointments, string name, string address, Location location, string phone, string mobil, string email, string misc)
        {
            uCtr.UpdateUser(user, appointments, name, address, location, phone, mobil, email, misc);
        }

        public void DeleteUser(User user)
        {
            uCtr.DeleteUser(user);
        }
    }
}
