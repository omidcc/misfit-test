﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Misfit.Model;

namespace Misfit.Data
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Update(T entity);
    }
}
