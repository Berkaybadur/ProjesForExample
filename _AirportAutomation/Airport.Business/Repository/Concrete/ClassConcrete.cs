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
    public class ClassConcrete : IClassRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Classes entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Classes entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Classes entity)
        {
            throw new NotImplementedException();
        }

        public List<Classes> Get()
        {
            return air.Class.ToList();
        }

        public Classes Get(int id)
        {
            return air.Class.FirstOrDefault();
        }
        public List<Classes> ListForComboBox()
        {
            List<Classes> list = air.Class.ToList();
            list.Insert(0, new Classes { ClassesId = 0, ClassName = "Seçiniz..." });
            return list;
        }
        public Classes SelectedItemClasses(int id)
        {
            return air.Class.Find(id);
        }
    }
}
