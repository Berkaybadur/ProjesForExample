using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Business.Repository.Concrete;
using Airport.DataEntities.Entities;

namespace Airport.Service
{
    public class AirportService : IAirportService
    {
        CountryConcrete con = new CountryConcrete();
        ProvinceConcrete pon = new ProvinceConcrete();
        CustomerConcrete cus = new CustomerConcrete();
        ExpeditionConcrete exp = new ExpeditionConcrete();
        PersonelConcrete per = new PersonelConcrete();
        TicketConcrete tic = new TicketConcrete();
        AirplaneConcrete plane = new AirplaneConcrete();
        AirportConcrete airport = new AirportConcrete();
        UserTicketConcrete user = new UserTicketConcrete();

        public void AddCountries(Countries countries)
        {
            con.Add(countries);
        }

        public void AddCustomer(Customers customers)
        {
            cus.Add(customers);
        }

        public void AddProvince(Province province)
        {
            pon.Add(province);
        }

        public void DeleteCountry(Countries id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProvince(Province id)
        {
            throw new NotImplementedException();
        }

        public List<Countries> GetCountries()
        {
            return con.Get();
        }

        public List<Customers> GetCustomers()
        {
            return cus.Get();
        }

        public List<Province> GetProvince()
        {
          return  pon.Get();
        }

        public void AddExpedition(Expedition expedition)
        {
            exp.Add(expedition);
        }

        public List<Expedition> GetExpedition()
        {
            return exp.Get();
        }

        public void AddPersonel(Personel personel)
        {
            per.Add(personel);
        }

        public List<Personel> GetPersonel()
        {
            return per.Get();
        }

        public void AddTicket(Ticket ticket)
        {
            tic.Add(ticket);
        }

        public List<Ticket> GetTicket()
        {
            return tic.Get();
        }

        public void AddAirplane(Airplane airplane)
        {
            plane.Add(airplane);
        }

        public List<Airplane> GetAirplane()
        {
            return plane.Get();
        }

        public List<Airports> ListForComboBox()
        {
           return airport.ListForComboBox();
        }

        public void DeleteAirplane(int id)
        {
            plane.Delete(id);
        }

        public void EditAirplane(Airplane airplane)
        {
            plane.Edit(airplane);
        }

        public void DeleteCustomer(int id)
        {
            cus.Delete(id);
        }

        public void EditCustomer(Customers customer)
        {
            cus.Edit(customer);
        }

        public void DeleteExpedition(int id)
        {
            exp.Delete(id);
        }

        public void EditExpedition(Expedition expedition)
        {
            exp.Edit(expedition);
        }

        public void DeletePersonel(int id)
        {
            per.Delete(id);
        }

        public void EditPersonel(Personel personel)
        {
            per.Edit(personel);
        }

        public void DeleteTicket(int id)
        {
            tic.Delete(id);
        }

        public void EditTicket(Ticket ticket)
        {
            tic.Edit(ticket);
        }

        public void AddUserTicket(UserTicket userticket)
        {
            user.Add(userticket);
        }

        public void EditUserTicket(UserTicket userticket)
        {
            user.Edit(userticket);
        }

        public void DeleteUserTicket(int id)
        {
            user.Delete(id);
        }

        public List<UserTicket> GetUserTicket()
        {
          return  user.Get();
        }
    }
}
