using Airport.Business.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.DataEntities.Entities;
using Airport.DataEntities.Context;

namespace Airport.Business.Repository.Concrete
{
    public class UserTicketConcrete : IUserTicketRepository
    {
        AirportContext air = new AirportContext();
        public void Add(UserTicket entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.UserTicket.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (AirportContext air = new AirportContext())
            {
                UserTicket userticket = air.UserTicket.Find(id);
                air.UserTicket.Remove(userticket);
                air.SaveChanges();
            }
        }

        public void Delete(UserTicket entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserTicket entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.UserTicket.Attach(entity);
                air.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                air.SaveChanges();
            }
        }

        public List<UserTicket> Get()
        {
            return air.UserTicket.ToList();
        }

        public UserTicket Get(int id)
        {
            throw new NotImplementedException();
        }
        public UserTicket SelectedItemUserTicket(int id)
        {
            return air.UserTicket.Find(id);
        }
    }
}
