using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WowApp.Host.Controllers.Admin
{
    [ApiExplorerSettings(GroupName = "admin")]
    [Produces("application/json")]
    [Route("api/admin/[controller]/[action]")]
    public abstract class AbstractAdminController<T> : AbstractBaseController<T>
    {
        protected AbstractAdminController(ILogger<T> logger) : base(logger)
        {
        }
    }
}