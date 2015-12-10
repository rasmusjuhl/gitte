/* 
 * Project name:    Planlægningsværktøj til ejendomsmæglere
 * Group members:   Kasper Løkke, Rasmus Juhl, Silas Christensen og Søren Kaae
 * Class:           DMAB0914
 * 
 * "ControlLayer" er det lag i programmet, som er bindeledet mellem 
 * DatabaseAccessLaget(kommunikation til database) og WCFServiceLaget(kommunikation ud) 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using ModelLayer;
using ModelLayer.DAL;

namespace ControlLayer
{
    public class UserController
    {
        private DBUser dbUser = new DBUser();


        public UserController()
        {

        }

        public void InsertUser(User user)
        {
            dbUser.InsertUser(user);
        }
        public User GetUserByPhone(string phone)
        {
            return dbUser.GetUserByPhone(phone);
        }

        public List<User> GetAllUsers()
        {
            return dbUser.GetAllUsers();
        }

        public void UpdateUser(User user, List<Appointment> appointments, string name, string address, string zipCode, string phone, string mobil, string email, string misc)
        {
            dbUser.UpdateUser(user, appointments, name, address, zipCode, phone, mobil, email, misc);
        }

        public void DeleteUser(User user)
        {
            dbUser.DeleteUser(user);
        }
    }
}
