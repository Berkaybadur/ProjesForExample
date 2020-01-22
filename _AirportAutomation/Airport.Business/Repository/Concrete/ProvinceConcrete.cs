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
    public class ProvinceConcrete : IProvinceRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Province entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Province.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Province entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Province entity)
        {
            throw new NotImplementedException();
        }

        public List<Province> Get()
        {
            using (AirportContext air = new AirportContext())
            {
              return  air.Province.ToList();
            }
        }

        public Province Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
