namespace WowApp.Database.Service
{
    internal class ServiceContainer : IServiceContainer
    {
        public IUserService User { get; }


        public ServiceContainer(
            IUserService userService
        )
        {
            User = userService;
        }
    }
}