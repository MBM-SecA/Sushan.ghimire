using Microsoft.AspNetCore.Mvc;

namespace Ems.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemosController : ControllerBase
    {
        [HttpGet("[action]")]
        public string[] GetName()
        {
            return new string[] {"Hello Solti", "K xa solti", "Sanchai ho solti"};
        }

        [HttpGet("fetchnames/{int}")]
        public string GetName(int id)
        {
            return "Hello Solti";
        }
    }
}