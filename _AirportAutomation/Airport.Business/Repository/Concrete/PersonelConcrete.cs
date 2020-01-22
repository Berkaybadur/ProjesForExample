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
    public class PersonelConcrete : IPersonelRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Personel entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Personel.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (AirportContext air = new AirportContext())
            {
                Personel personel = air.Personel.Find(id);
                air.Personel.Remove(personel);
                air.SaveChanges();
            }
        }

        public void Delete(Personel entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Personel entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Personel.Attach(entity);
                air.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                air.SaveChanges();
            }
        }

        public List<Personel> Get()
        {
            return air.Personel.ToList();
        }

        public Personel Get(int id)
        {
            throw new NotImplementedException();
        }
        public Personel SelectedItemPersonel(int id)
        {
            return air.Personel.Find(id);
        }
    }
}
