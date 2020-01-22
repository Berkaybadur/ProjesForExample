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
    public class DegreeConcrete : IDegreeRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Degree entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.Degree.Add(entity);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Degree entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Degree entity)
        {
            throw new NotImplementedException();
        }

        public List<Degree> Get()
        {
            return air.Degree.ToList();
        }

        public Degree Get(int id)
        {
            throw new NotImplementedException();
        }
        public List<Degree> ListForComboBox()
        {
            List<Degree> list = air.Degree.ToList();
            list.Insert(0, new Degree { DegreeId = 0, Name = "Seçiniz..." });
            return list;
        }
        public List<Degree> ListForComboBoxRegister()
        {
            List<Degree> list = air.Degree.ToList();
            list.Insert(0, new Degree { DegreeId = 2, Name ="Kullanıcı" });
            return list;
        }

    }
}
