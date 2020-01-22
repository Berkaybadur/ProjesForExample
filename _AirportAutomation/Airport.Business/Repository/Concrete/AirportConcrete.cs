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
    public class AirportConcrete : IAirportRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Airports entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Airports.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Airports entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Airports entity)
        {
            throw new NotImplementedException();
        }

        public List<Airports> Get()
        {
            return air.Airports.ToList();
        }

        public Airports Get(int id)
        {
            return air.Airports.FirstOrDefault();
        }
        public List<Airports> ListForComboBox()
        {
            List<Airports> list = air.Airports.ToList();
            list.Insert(0, new Airports { AirportId = 0, AirportName= "Seçiniz..." });
            return list;
        }
    }
}
