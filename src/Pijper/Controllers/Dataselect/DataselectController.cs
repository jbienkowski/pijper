using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Pijper.Controllers.Dataselect
{
    [Route("fdsnws/dataselect/1")]
    [ApiController]
    public class DataselectController : Controller
    {
        private IConfiguration _config;

        // Constructor
        public DataselectController(IConfiguration iConfig) {
            _config = iConfig;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return View();
        }
    }
}
