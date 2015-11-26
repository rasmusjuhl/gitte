﻿using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void InsertUser(User user);

        [OperationContract]
        User GetUserUserByPhone(string phone);

        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        void UpdateUser(User user, List<Appointment> appointments, string name, string address, string zipCode, Location location, string phone, string mobil, string email, string misc);

        [OperationContract]
        void DeleteUser(User user);
    }
}
