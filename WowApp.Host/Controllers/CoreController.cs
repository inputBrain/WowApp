using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Database.Service;

namespace WowApp.Host.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class CoreController : AbstractBaseController<CoreController>
    {
        private readonly IServiceContainer _serviceContainer;

        public CoreController(ILogger<CoreController> logger, IServiceContainer serviceContainer) : base(logger)
        {
            _serviceContainer = serviceContainer;
        }
        
    //     [HttpGet]
    //     public void GetRandomChance(int chance = 0)
    //     {
    //         var gift = 0;
    //         var attempt = 0;
    //         var attempts = new List<int>();
    //         do
    //         {
    //             var random = new Random();
    //             var randomNumber = random.Next(0, 100);
    //             attempt++;
    //
    //             if (randomNumber <= chance)
    //             {
    //                 gift++;
    //                 attempts.Add(attempt);
    //                 // Console.WriteLine($"Attempts: {attempt}. Successful. You get gift");
    //                 attempt = 0;
    //             }
    //         } while (gift <= 9999);
    //
    //         var avg = attempts.Average();
    //         
    //         Console.WriteLine($"Avarage attempt: {avg}. Successful. You get gift");
    //     }
    // } // 33.321879

    }
}