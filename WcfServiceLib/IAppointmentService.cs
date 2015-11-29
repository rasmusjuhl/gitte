using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;

namespace WcfServiceLib
{
    [ServiceContract]
    public interface IAppointmentService
    {
        [OperationContract]
        void InsertAppointment(Appointment appointment);
        [OperationContract]
        Appointment GetAppointment(DateTime date);
        [OperationContract]
        List<Appointment> GetAllAppointments();
        [OperationContract]
        void UpdateAppointment(Appointment appointment, DateTime date, DateTime StartTime, DateTime EndTime,
            string category, string descricption, string status, Seller seller, Buyer buyer);
        [OperationContract]
        void DeleteAppointment(Appointment appointment);
    }
}
