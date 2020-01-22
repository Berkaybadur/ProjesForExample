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
    public class TitleConcrete : ITitleRepository
    {
        AirportContext air = new AirportContext();
        public void Add(Title entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Title entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Title entity)
        {
            throw new NotImplementedException();
        }

        public List<Title> Get()
        {
            return air.Title.ToList();
        }

        public Title Get(int id)
        {
            throw new NotImplementedException();
        }
        public List<Title> ListForComboBox()
        {
            List<Title> list = air.Title.ToList();
            list.Insert(0, new Title { TitleId = 0, TitleName = "Seçiniz..." });
            return list;
        }
    }
}
