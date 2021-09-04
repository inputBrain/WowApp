using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers
{
    public class UserController : AbstractBaseController<UserController>
    {
        private readonly IServiceContainer _sc;


        public UserController(ILogger<UserController> logger, IServiceContainer sc) : base(logger)
        {
            _sc = sc;
        }


        [HttpGet]

        public async Task<IActionResult> GetOne(int id)
        {
            var model = await _sc.UserService.GetOne(id);
            return SendOk(model);
        }
    }

}