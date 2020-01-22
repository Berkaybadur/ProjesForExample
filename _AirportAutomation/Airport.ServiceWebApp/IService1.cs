using Airport.DataEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Airport.ServiceWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Countries> GetCountries();
        [OperationContract]
        void AddCountries(Countries countries);
        [OperationContract]
        void DeleteCountry(Countries id);
        [OperationContract]
        void AddProvince(Province province);
        [OperationContract]
        void DeleteProvince(Province id);
        [OperationContract]
        List<Province> GetProvince();
        [OperationContract]
        void AddCustomer(Customers customers);
        [OperationContract]
        List<Customers> GetCustomers();
        [OperationContract]
        void AddExpedition(Expedition expedition);
        [OperationContract]
        List<Expedition> GetExpedition();
        [OperationContract]
        void AddPersonel(Personel personel);
        [OperationContract]
        List<Personel> GetPersonel();
        [OperationContract]
        void AddTicket(Ticket ticket);
        [OperationContract]
        List<Ticket> GetTicket();
        [OperationContract]
        void AddAirplane(Airplane airplane);
        [OperationContract]
        List<Airplane> GetAirplane();
        [OperationContract]
        List<Airports> ListForComboBox();
        [OperationContract]
        void DeleteAirplane(int id);
        [OperationContract]
        void EditAirplane(Airplane airplane);
        [OperationContract]
        void DeleteCustomer(int id);
        [OperationContract]
        void EditCustomer(Customers customer);
        [OperationContract]
        void DeleteExpedition(int id);
        [OperationContract]
        void EditExpedition(Expedition expedition);
        [OperationContract]
        void DeletePersonel(int id);
        [OperationContract]
        void EditPersonel(Personel personel);
        [OperationContract]
        void DeleteTicket(int id);
        [OperationContract]
        void EditTicket(Ticket ticket);
        [OperationContract]
        void AddUserTicket(UserTicket userticket);
        [OperationContract]
        void EditUserTicket(UserTicket userticket);
        [OperationContract]
        void DeleteUserTicket(int id);
        [OperationContract]
        List<UserTicket> GetUserTicket();
    }
}
