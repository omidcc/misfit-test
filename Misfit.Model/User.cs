using System;
using System.Collections.Generic;

namespace Misfit.Model
{
    public class User : BaseEntity
    {
        public User()
        {
        }
        public string UserName { get; set; }
        public virtual ICollection<UserResult> Results { get; set; }
    }
}
