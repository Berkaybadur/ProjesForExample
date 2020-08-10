using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TravelApp.Entities;
using Xamarin.Forms;

namespace TravelApp.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBasecs<TEntity, TContext> : IEntitiyRepository<TEntity>
       where TEntity : class, IEntity, new()
      where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public List<TEntity> GetInclude(Expression<Func<TEntity, object>> expression)
        {
            using (var context = new TContext())
            {
                return expression == null ?
                    context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Include(expression).ToList();
            }
        }

        public List<TEntity> GetIncludee(Expression<Func<TEntity, object>> expression , Expression<Func<TEntity, object>> expression2)
        {
            using (var context = new TContext())
            {
                return expression ==null||expression2==null?
                    context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Include(expression).Include(expression2).ToList();
            }
        }
    }
}
    
