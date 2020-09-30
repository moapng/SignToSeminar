using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignToSeminarBackEnd.Context;

namespace SignToSeminarBackEnd.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "indexpage!!!";

        }
    }
}
