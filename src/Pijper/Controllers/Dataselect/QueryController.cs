using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pijper.Controllers.Dataselect
{
    [Route("dataselect/1/query")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "query";
        }
    }
}
