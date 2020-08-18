using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        private bool _disposed;
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity entity) => _repository.Add(entity);

        public bool Delete(TEntity entity)
        {
            _repository.Delete(entity);
            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public TEntity GetById(int id) => _repository.GetById(id);

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate) => _repository.GetList(predicate);

        public bool Update(TEntity entity)
        {
            _repository.Update(entity);
            return true;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _repository?.Dispose();
            }

            _disposed = true;
        }
    }
}
