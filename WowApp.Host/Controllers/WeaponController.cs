using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers
{
    public class WeaponController: AbstractBaseController<WeaponController>
    {
        private readonly IServiceContainer _serviceContainer;

        public WeaponController(ILogger<WeaponController> logger, IServiceContainer serviceContainer) : base(logger)
        {
            _serviceContainer = serviceContainer;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeapon(int id)
        {
            var model = await _serviceContainer.Weapon.GetOne(id);
            return SendOk(model);
        }

    }
}