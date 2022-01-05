using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        public void GetGiftByChance(int chance = 2)
        {
            var gift = 0;
            var boxNumber = 0;
            var firstBox = 0;
            var boxNumberCollection = new List<int>();
            var random = new Random();

            do
            {
                boxNumber++;
                var randomChance = random.Next(0, 100);
                if (randomChance <= chance)
                { 
                    gift++;
                    boxNumberCollection.Add(boxNumber);
                    if (boxNumber == 1)
                    {
                        firstBox++;
                    }
                    // Console.WriteLine($"Success! Box number #: {boxNumber}. You got the gift");
                    boxNumber = 0;
                }
            } while (gift <= 999999);

            var avg = boxNumberCollection.Average();
            
            Console.WriteLine($"In average, you need to open: {avg} boxes to get the gift.");
            Console.WriteLine($"\n You got the gift from the first box: {firstBox} times");

            
        }
    } // 33.321879
}