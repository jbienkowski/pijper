using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Pijper.Data;
using Pijper.Models.Station;

namespace Pijper.Controllers.Station
{
    [Route("fdsnws/station/1/query")]
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
            var sqm = new StationQueryModel(query);
            return query;
        }
    }
}
