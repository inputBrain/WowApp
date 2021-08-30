using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WowApp.Host.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public abstract class AbstractBaseController<T> : ControllerBase
    {
        protected readonly ILogger<T> Logger;


        protected AbstractBaseController(ILogger<T> logger)
        {
            Logger = logger;
        }


        protected IActionResult SendOk(object response)
        {
            return Ok(response);
        }

        protected IActionResult SendOk()
        {
            return Ok();
        }

    }
}