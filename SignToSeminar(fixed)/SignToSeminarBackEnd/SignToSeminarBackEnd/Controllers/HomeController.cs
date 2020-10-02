using Microsoft.AspNetCore.Mvc;

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
