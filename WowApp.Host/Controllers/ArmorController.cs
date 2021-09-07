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
        public async Task<IActionResult> GetArmor(int id)
        {
            var model = await _serviceContainer.ArmorService.GetOne(id);
            return SendOk($"Title:{model.Title}, Cover:{model.Cover}, Weight:{model.Weight}");
        }
        
        [HttpGet]
        public async Task<IActionResult> GetArmorTitle(int id)
        {
            var model = await _serviceContainer.ArmorService.GetTitle(id);
            return SendOk(model.Title);
        }
    }
}