using Domain.Entities;
using Domain.Repositories;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected LibraryContext Context = new LibraryContext();

        public TEntity Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public TEntity GetById(int id) => Context.Set<TEntity>().Find(id);

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return true;
        }
    }
}
