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
    public class DistrictConcrete : IDistrictRepository
    {
        AirportContext air = new AirportContext();
        public void Add(District entity)
        {
            using (AirportContext air = new AirportContext())
            {
                air.District.Add(entity);
                air.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(District entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(District entity)
        {
            throw new NotImplementedException();
        }

        public List<District> Get()
        {
            return air.District.ToList();
        }

        public District Get(int id)
        {
            throw new NotImplementedException();
        }
        public List<District> ListForComboBox()
        {
            List<District> list = air.District.ToList();
            list.Insert(0, new District { DistrictId = 0, DistrictName = "Şehir Seçiniz..." });
            return list;
        }
    }
}
