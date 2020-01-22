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
    public class AirplaneConcrete : IAirplaneRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Airplane entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Airplane.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (AirportContext air = new AirportContext())
            {
                Airplane airplane = air.Airplane.Find(id);
                air.Airplane.Remove(airplane);
                air.SaveChanges();
            }
        }

        public void Delete(Airplane entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Airplane.Remove(entity);
                air.SaveChanges();
            }
        }

        public void Edit(Airplane entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Airplane.Attach(entity);
                air.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                air.SaveChanges();
            }
        }

        public List<Airplane> Get()
        {
            return air.Airplane.ToList();
        }

        public Airplane Get(int id)
        {
            return air.Airplane.FirstOrDefault();
        }
        public List<Airplane> ListForComboBox()
        {
            List<Airplane> list = air.Airplane.ToList();
            list.Insert(0, new Airplane { AirplaneId = 0, AirplaneName = "Seçiniz..." });
            return list;
        }
        public Airplane SelectedItemAirplane(int id)
        {
           return air.Airplane.Find(id);
        }
      
    }
}
