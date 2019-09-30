using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Misfit.Model;

namespace Misfit.Data
{
    public class UserRepository : BaseRepository<User>
    {
        private MisfitDbContext _MisfitDbContext;
        public UserRepository(MisfitDbContext misfitDbContext)
        {
            _MisfitDbContext = misfitDbContext;
        }

    }
}
