using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Misfit.Manager;


namespace Misfit.Web.Controllers
{
    [Route("api/v1/number")]
    public class NumberController : Controller
    {
        private IMisfitNumberManager _MisfitNumberManager;
        public NumberController(IMisfitNumberManager misfitNumberManager)
        {
            _MisfitNumberManager = misfitNumberManager;
        }
       
        [HttpGet("result")]
        public IEnumerable<string> Get()
        {
            var result = _MisfitNumberManager.Add(2, 3);
            return new string[] { "value1", "value2", result.ToString() };
        }

        
    }
}
