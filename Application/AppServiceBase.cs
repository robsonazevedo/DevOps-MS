using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : EntityBase
    {
        private bool _disposed;
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public TEntity Add(TEntity entity) => _service.Add(entity);

        public bool Delete(TEntity entity)
        {
            _service.Delete(entity);
            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public TEntity GetById(int id) => _service.GetById(id);

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate) => _service.GetList(predicate);

        public bool Update(TEntity entity)
        {
            _service.Update(entity);
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
                _service?.Dispose();
            }

            _disposed = true;
        }
    }
}
