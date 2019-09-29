using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Misfit.Model;

namespace Misfit.Data
{
    public class UserRepository : IUserRepository
    {
        private MisfitDbContext _MisfitDbContext;
        public UserRepository(MisfitDbContext misfitDbContext)
        {
            _MisfitDbContext = misfitDbContext;
        }

        public User Add(User user)
        {
            return Add(user);
        }

        public IQueryable<User> FindBy(Expression<Func<User, bool>> predicate)
        {
            return FindBy(predicate);
        }

        public IQueryable<User> GetAll()
        {
            return GetAll();
        }

        public User GetById(int id)
        {
            return GetById(id);
        }

        public User Update(User user)
        {
            return Update(user);
        }
    }
}
