using Microsoft.Extensions.Logging;

namespace WowApp.Database
{
    public abstract class AbstractRepository<T> where T : AbstractModel
    {
        protected ILogger<T> Logger;


        protected AbstractRepository(ILoggerFactory loggerFactory)
        {
            Logger = loggerFactory.CreateLogger<T>();
        }
    }
}