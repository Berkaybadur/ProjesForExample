using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TravelApp.Entities;

namespace TravelApp.DataAccess
{
	public interface IEntitiyRepository<T> where T : class, IEntity, new()
	{
		T Get(Expression<Func<T, bool>> filter = null);
		List<T> GetList(Expression<Func<T, bool>> filter = null);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		List<T> GetInclude(Expression<Func<T, object>> expression = null);
		List<T> GetIncludee(Expression<Func<T, object>> expression = null,Expression<Func<T,object>> expression2=null);

	}
}
