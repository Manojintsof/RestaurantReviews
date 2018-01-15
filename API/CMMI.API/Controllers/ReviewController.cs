using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CMMI.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public IEnumerable<string> Post()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
