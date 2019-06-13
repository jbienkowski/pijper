using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pijper.Controllers.Dataselect
{
    [Route("fdsnws/dataselect/1/version")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "1.2.0";
        }
    }
}
