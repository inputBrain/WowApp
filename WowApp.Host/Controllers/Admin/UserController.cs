using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers.Admin
{
    public class UserController : AbstractAdminController<UserController>
    {
        private readonly IServiceContainer _serviceContainer;

        public UserController(ILogger<UserController> logger, IServiceContainer serviceContainer) : base(logger)
        {
            _serviceContainer = serviceContainer;
        }


        //https://localhost:5001/api/admin/user/getone?id=1
        [HttpGet]
        public async Task<IActionResult> GetOne(int id)
        {
            var user = await _serviceContainer.User.GetOne(id);

            return SendOk(user);
        }
    }
}