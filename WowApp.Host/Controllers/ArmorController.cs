using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers
{
    public class ArmorController: AbstractBaseController<ArmorController>
    {
        private readonly IServiceContainer _serviceContainer;
        public ArmorController(ILogger<ArmorController> logger, IServiceContainer serviceContainer) : base(logger)
        {
            _serviceContainer = serviceContainer;
        }


        [HttpGet]
        public async Task<IActionResult> GetArmorById(int id)
        {
            var model = await _serviceContainer.Armor.GetOne(id);
            return SendOk(model);
        }
    }
}