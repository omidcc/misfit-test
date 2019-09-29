using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Misfit.Manager;


namespace Misfit.Web.Controllers
{
    [Route("api/v1/")]
    public class UserController : Controller
    {
        private IUserManager _UserManager;
        private IMisfitNumberManager _MisfitNumberManager;
        public UserController(IUserManager userManager, IMisfitNumberManager misfitNumberManager)
        {
            _UserManager = userManager;
            _MisfitNumberManager = misfitNumberManager;
        }

        
    }
}
