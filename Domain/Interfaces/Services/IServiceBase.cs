﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : EntityBase
    {
        TEntity Add(TEntity entity);
        bool Delete(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
        bool Update(TEntity entity);
    }
}
