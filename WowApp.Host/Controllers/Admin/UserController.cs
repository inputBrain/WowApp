using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WowApp.Client.Codec;
using WowApp.Client.User;
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
        [ProducesResponseType(typeof(GetOneUser.Response), 200)]
        public async Task<GetOneUser.Response> GetOne(int id)
        {
            var user = await _serviceContainer.User.GetOne(id);

            return new GetOneUser.Response(UserCodec.EncodeUser(user));
        }

        [HttpGet]
        public void GetRandomChance(int chance = 0)
        {

            var robot = 0;
            var box = 0;
            var firstBox = 0;
            var opeens = new List<int>();
            var random = new Random();

            do
            {
                box++;
                var randomNumber = random.Next(0, 100);
                if (randomNumber <= chance)
                {
                    robot++;
                    opeens.Add(box);
                    if (box == 1)
                    {
                        firstBox++;
                    }
                    // Console.WriteLine($"Attempts: {attempt}. Successful. You get gift");
                    box = 0;
                }
            } while (robot <= 9999999);

            var avg = opeens.Average();
            
            Console.WriteLine($"Avarage attempt: {avg}. Successful. You get gift");
            Console.WriteLine($"First times: {firstBox}. Wowow");

            
        }
    } // 33.321879
}