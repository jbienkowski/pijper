using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace Pijper.Controllers.Dataselect
{
    [Route("dataselect/1/query")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<Dictionary<string, Microsoft.Extensions.Primitives.StringValues>> Get()
        {
            
            var query = QueryHelpers.ParseQuery(
                HttpContext.Request.QueryString.Value
            );
            return query;
        }
    }
}
