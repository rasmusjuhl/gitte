using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlLayer;
using ModelLayer;

namespace WcfServiceLib
{
    public class UserService : IUserService
    {
        static UserController uCtr = new UserController();
        public List<User> GetAllUsers()
        {
            return uCtr.GetAllUsers();
        }
    }
}
