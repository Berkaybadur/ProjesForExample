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
    public class CustomerConcrete : ICustomersRepository
    {
        AirportContext air = new AirportContext();

        public void Add(Customers entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Customers.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (AirportContext air = new AirportContext())
            {
                Customers customer = air.Customers.Find(id);
                air.Customers.Remove(customer);
                air.SaveChanges();
            }
        }

        public void Delete(Customers entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Customers entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Customers.Attach(entity);
                air.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                air.SaveChanges();
            }
        }

        public List<Customers> Get()
        {
            return air.Customers.ToList();
        }

        public Customers Get(int id)
        {
            throw new NotImplementedException();
        }
        public List<Customers> ListForComboBox()
        {
            List<Customers> list = air.Customers.ToList();
            list.Insert(0, new Customers { CustomerId = 0, CustomerName = "Seçiniz..." });
            return list;
        }
        public Customers SelectedItemCustomer(int id)
        {
            return air.Customers.Find(id);
        }
    }
}
