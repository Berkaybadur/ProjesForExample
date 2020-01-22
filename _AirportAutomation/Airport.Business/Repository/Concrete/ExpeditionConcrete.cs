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
    public class ExpeditionConcrete : IExpeditionRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Expedition entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Expedition.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (AirportContext air = new AirportContext())
            {
                Expedition expedition = air.Expedition.Find(id);
                air.Expedition.Remove(expedition);
                air.SaveChanges();
            }
        }

        public void Delete(Expedition entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Expedition entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Expedition.Attach(entity);
                air.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                air.SaveChanges();
            }
        }

        public List<Expedition> Get()
        {
            using (AirportContext air = new AirportContext())
            {
                return air.Expedition.ToList();
            }
        }

        public Expedition Get(int id)
        {
            throw new NotImplementedException();
        }
        public List<Expedition> ListForComboBox()
        {
            List<Expedition> list = air.Expedition.ToList();
            list.Insert(0, new Expedition { ExpeditionId = 0, RotationLocation = "Seçiniz..." });
            return list;
        }
        public Expedition SelectedItemExpedition(int id)
        {
            return air.Expedition.Find(id);
        }
    }
}
