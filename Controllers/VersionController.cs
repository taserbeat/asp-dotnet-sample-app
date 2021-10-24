using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using asp_dotnet_sample_app.Models;

namespace asp_dotnet_sample_app.Controllers
{
    [Route("/api/version")]
    public class VersionController : ControllerBase
    {
        private readonly ILogger<VersionController> _logger;

        public VersionController(ILogger<VersionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<ServiceVersion> GetVersion()
        {
            var a = 1;

            a++;

            var b = a + 1;

            return new ServiceVersion();
        }
    }
}
