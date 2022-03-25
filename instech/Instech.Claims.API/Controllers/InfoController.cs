using Microsoft.AspNetCore.Mvc;

namespace Instech.Claims.API.Controllers
{
    [ApiController]
    [Route("")]
    public class InfoController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "Instech Claim API";
        }
    }
}
