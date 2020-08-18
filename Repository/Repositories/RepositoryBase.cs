using Domain.Entities;
using Domain.Interfaces.Repositories;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected LibraryContext Context = new LibraryContext();

        public TEntity Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public bool Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity GetById(int id) => Context.Set<TEntity>().Find(id);

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate) => Context.Set<TEntity>().Where(predicate);

        public bool Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return true;
        }
    }
}
