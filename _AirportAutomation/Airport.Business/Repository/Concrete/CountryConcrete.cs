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
    public class CountryConcrete : ICountryRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Countries entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Country.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
              using (AirportContext air = new AirportContext())
                {
                    Countries country = air.Country.Find(id);
                    air.Country.Remove(country);
                    air.SaveChanges();
                }
        }

        public void Delete(Countries entity)
        {
            Countries country = air.Country.Find(entity);
            air.Country.Remove(country);
            air.SaveChanges();
        }

        public void Edit(Countries entity)
        {
            throw new NotImplementedException();
        }

        public List<Countries> Get()
        {
            using (AirportContext air = new AirportContext())
            {
                return air.Country.ToList();
            }
        }

        public Countries Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
