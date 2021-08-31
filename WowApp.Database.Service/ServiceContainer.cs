namespace WowApp.Database.Service
{
    internal class ServiceContainer : IServiceContainer
    {
        public IUserService UserService { get; }


        public ServiceContainer(
            IUserService userService
        )
        {
            UserService = userService;
        }
    }
}