using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyConfigController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MyConfigController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IDictionary<string, string?> Get()
        {
            return _configuration.GetSection("Demo")
                          .GetChildren()
                          .ToDictionary(a => a.Key, a => a.Value);

        }
    }
}
