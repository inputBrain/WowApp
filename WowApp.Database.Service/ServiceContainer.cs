namespace WowApp.Database.Service
{
    // Читать в UserService.
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