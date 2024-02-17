using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController   : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            return "ridhons";
        }
        [HttpGet]
        public string GetFullName()
        {
            return "rejaul karim";
        }
    }
}
