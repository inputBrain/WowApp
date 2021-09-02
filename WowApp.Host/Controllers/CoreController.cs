using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers
{
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


        [HttpGet]
        public async Task<IActionResult> GetOne(int id)
        {
            var model = await _serviceContainer.UserService.GetOne(id);

            return SendOk(model);
        }
    }
}