using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace copaSescUser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet(Name = "Teste")]
        public string Valores(string valores)
        {
            return "Ola";

        }
    }
}
