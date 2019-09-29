using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Misfit.Manager;
using Misfit.Web.ViewModels;
using AutoMapper;
using Misfit.Model;

namespace Misfit.Web.Controllers
{
    [Route("api/v1/misfit")]
    public class MisfitController : Controller
    {
        private IUserManager _UserManager;
        private IMisfitNumberManager _MisfitNumberManager;
        private IMapper _Mapper;
        public MisfitController(IUserManager userManager, IMisfitNumberManager misfitNumberManager, IMapper mapper)
        {
            _Mapper = mapper;
            _UserManager = userManager;
            _MisfitNumberManager = misfitNumberManager;
        }

        [HttpPost("result")]
        public IActionResult SaveUserResult(ResultViewModel resultViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return UnprocessableEntity("Required Validation failed!");
                }
                resultViewModel.Sum = _MisfitNumberManager.Sum(resultViewModel.FirstNumber, resultViewModel.SecondNumber);
                var user = _UserManager.SaveUser(_Mapper.Map<User>(resultViewModel.User));
                if (user != null)
                {
                    resultViewModel.User.Id = user.Id;
                    var userResult = _UserManager.SaveUserResult(_Mapper.Map<UserResult>(resultViewModel));
                    resultViewModel.User.UserName = userResult.User.UserName;
                }
                return Ok(resultViewModel);

            }
            catch(Exception ex)
            {
                var error = ex.Message;
            }
            return BadRequest("Could not save result");
        }
    }
}
