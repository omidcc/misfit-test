using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Misfit.Model;

namespace Misfit.Data
{
    public class UserResultRepository : IUserResultRepository
    {
        private MisfitDbContext _MisfitDbContext;
        public UserResultRepository(MisfitDbContext misfitDbContext)
        {
            _MisfitDbContext = misfitDbContext;
        }

        public UserResult Add(UserResult userResult)
        {
            return Add(userResult);
        }

        public IQueryable<UserResult> FindBy(Expression<Func<UserResult, bool>> predicate)
        {
            return FindBy(predicate);
        }

        public IQueryable<UserResult> GetAll()
        {
            return GetAll();
        }

        public UserResult GetById(int id)
        {
            return GetById(id);
        }

        public UserResult Update(UserResult userResult)
        {
            return Update(userResult);
        }
    }
}
