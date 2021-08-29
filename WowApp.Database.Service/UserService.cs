using Microsoft.Extensions.Logging;
using WowApp.Database.User;
using WowApp.Model.User;

namespace WowApp.Database.Service
{
    // На первый взгяд, это одно и тоже что и UserRepository, только UserService.
    // В этом сервисе должны данные подготавливаться для репозитория. Мотивация
    // для создания этого сервиса и остальных — SOLID.

    // Все интерфейсы сервисов должны описываться в контейнере для сервисов и обьекты создаваться в Абстрактной Фабрике (Factory)

    // internal - Этот класс можно использовать ТОЛЬКО в рамках пакета в котором он создан. В данном случае - WowApp.Database.Service
    // Потому что у нас есть Factory.
    internal class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IUserRepository _userRepository;

        public UserService(
            ILogger<UserService> logger,
            IUserRepository userRepository
        )
        {
            _logger = logger;
            _userRepository = userRepository;
        }


        public UserModel Create(string firstName, string lastName, string cover, UserRole role)
        {
            //Подготовка данных. Например:

            // var nameToLower = firstName.ToLower();
            // return _userRepository.Create(nameToLower, ...)

            // или:

            // if(cover == null)
            // {
            //      cover += "Фоточка";
            // }

            return _userRepository.Create(firstName, lastName, cover, role);
        }


        public string GetTitleMessage()
        {
            return "Hi from User Service";
        }
    }
}