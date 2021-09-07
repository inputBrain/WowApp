using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers
{
    public class UserController : AbstractBaseController<UserController>
    {
        private readonly IServiceContainer _serviceContainer;


        public UserController(ILogger<UserController> logger, IServiceContainer serviceContainer) : base(logger)
        {
            _serviceContainer = serviceContainer;
        }


        [HttpGet]

        public async Task<IActionResult> GetOne(int id)
        {
            var model = await _serviceContainer.User.GetOne(id);
            return SendOk(model);
        }
    }

}