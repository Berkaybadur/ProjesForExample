using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Business.UnitOfWork.Abstract
{
   public interface IRepository<T> where T:class
    {
        List<T> Get();
        T Get(int id);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
