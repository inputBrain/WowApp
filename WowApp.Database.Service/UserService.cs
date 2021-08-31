using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WowApp.Database.User;
using WowApp.Model.User;

namespace WowApp.Database.Service
{
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


        public async Task<UserModel> Create(string firstName, string lastName, string cover, UserRole role)
        {
            return await _userRepository.Create(firstName, lastName, cover, role);
        }


        public string GetTitleMessage()
        {
            return "Hi from User Service";
        }
    }
}