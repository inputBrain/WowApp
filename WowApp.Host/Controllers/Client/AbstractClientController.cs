using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WowApp.Host.Controllers.Client
{
    [ApiExplorerSettings(GroupName = "client")]
    [Produces("application/json")]
    [Route("api/client/[controller]/[action]")]
    public abstract class AbstractClientController<T> : AbstractBaseController<T>
    {
        protected AbstractClientController(ILogger<T> logger) : base(logger)
        {
        }
    }
}