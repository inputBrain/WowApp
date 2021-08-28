using Microsoft.Extensions.Logging;
using WowApp.Database.User;

namespace WowApp.Database
{
    public class DatabaseContainer : IDatabaseContainer
    {
        public IUserRepository User { get; }


        public DatabaseContainer(ILoggerFactory loggerFactory)
        {
            User = new UserRepository(loggerFactory);
        }
    }
}