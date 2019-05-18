using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pijper.Controllers.Dataselect
{
    [Route("[controller]/1")]
    [ApiController]
    public class DataselectController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return View();
        }
    }
}
