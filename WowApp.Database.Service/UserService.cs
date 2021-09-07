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


        public async Task<IUser> GetOne(int id)
        {
            return await _userRepository.GetOne(id);
        }


        public async Task<UserModel> GetFull(int id)
        {
            return await _userRepository.GetFull(id);
        }


    }
}