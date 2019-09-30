using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Misfit.Model;

namespace Misfit.Data
{
    public class UserResultRepository : BaseRepository<UserResult>
    {
        private MisfitDbContext _MisfitDbContext;
        public UserResultRepository(MisfitDbContext misfitDbContext)
        {
            _MisfitDbContext = misfitDbContext;
        }
    }
}
