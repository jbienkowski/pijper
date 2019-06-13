using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pijper.Controllers.Station
{
    [Route("fdsnws/station/1")]
    [ApiController]
    public class StationController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return View();
        }
    }
}
