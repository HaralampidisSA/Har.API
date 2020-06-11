using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Har.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        public IActionResult Get()
        {
            var claims = User.Claims;
            return new JsonResult(claims.Select(s => new { s.Type, s.Value }));
        }
    }
}
