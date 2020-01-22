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
    public class TicketConcrete : ITicketRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Ticket entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Ticket.Add(entity);
                air.SaveChanges();
            }
    }

        public void Delete(int id)
        {
            using (AirportContext air = new AirportContext())
            {
                Ticket ticket = air.Ticket.Find(id);
                air.Ticket.Remove(ticket);
                air.SaveChanges();
            }
        }

        public void Delete(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Ticket entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Ticket.Attach(entity);
                air.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                air.SaveChanges();
            }
        }

        public List<Ticket> Get()
        {
            return air.Ticket.ToList();
        }

        public Ticket Get(int id)
        {
            throw new NotImplementedException();
        }
        public Ticket SelectedItemTicket(int id)
        {
            return air.Ticket.Find(id);
        }
    }
}
