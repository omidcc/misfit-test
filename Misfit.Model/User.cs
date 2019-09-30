using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Misfit.Model
{
    [Table("User")]
    public class User : BaseEntity
    {
        public User()
        {
        }
        public string UserName { get; set; }
        public virtual ICollection<UserResult> Results { get; set; }
    }
}
