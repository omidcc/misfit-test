using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Misfit.Web.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public List<ResultViewModel> Results { get; set; }
    }
}
