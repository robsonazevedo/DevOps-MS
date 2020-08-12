﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        TEntity Add(TEntity entity);
        bool Delete(TEntity entity);
        void Dispose();
        TEntity GetById(int id);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
        bool Update(TEntity entity);
    }
}
