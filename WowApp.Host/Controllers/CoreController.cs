using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class CoreController : AbstractBaseController<CoreController>
    {
        private readonly IServiceContainer _serviceContainer;

        public CoreController(ILogger<CoreController> logger, IServiceContainer serviceContainer) : base(logger)
        {
            _serviceContainer = serviceContainer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_serviceContainer.UserService.GetTitleMessage());
        }
    }
}