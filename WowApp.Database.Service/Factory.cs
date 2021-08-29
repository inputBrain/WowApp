using Microsoft.Extensions.Logging;

namespace WowApp.Database.Service
{
    // Dependency Injection... + Паттерн проектирования Абстрактная Фабрика
    public class Factory
    {
        public static IServiceContainer Create(
            ILoggerFactory loggerFactory,
            IDatabaseContainer databaseContainer
        )
        {
            return new ServiceContainer(
                new UserService(
                    loggerFactory.CreateLogger<UserService>(),
                    databaseContainer.User
                )
            );
        }
    }
}