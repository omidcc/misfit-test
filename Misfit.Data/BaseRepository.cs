using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Misfit.Model;

namespace Misfit.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private DbContext _Context = null;
        private DbSet<T> _Entities = null;

        public BaseRepository()
        {
            this._Context = new MisfitDbContext();
            _Entities = _Context.Set<T>();
        }

        public BaseRepository(MisfitDbContext context)
        {
            this._Context = context;
            _Entities = _Context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _Entities.AsQueryable<T>();
            return query;
        }

        public virtual T GetById(int id)
        {
            T entity = _Entities.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _Entities.AsQueryable<T>().Where(predicate);
            return query;
        }

        public virtual T Add(T entity)
        {
            _Context.Entry(entity).State = EntityState.Added;
            entity = _Entities.Add(entity).Entity;
            _Context.SaveChanges();
            return entity;
        }


        public virtual T Update(T entity)
        {
            _Context.Entry(entity).State = EntityState.Modified;
            entity = _Entities.Update(entity).Entity;
            _Context.SaveChanges();
            return entity;
        }
    }
}
