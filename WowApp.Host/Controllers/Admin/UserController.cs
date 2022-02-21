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


        [HttpGet]
        [ProducesResponseType(typeof(GetOneUser.Response), 200)]
        public async Task<GetOneUser.Response> GetOne(int id)
        {
            var user = await _serviceContainer.User.GetOne(id);

            return new GetOneUser.Response(UserCodec.EncodeUser(user));
        }
    }
}