namespace WowApp.Database.Service
{
    public interface IServiceContainer
    {
        IUserService UserService { get; }
    }
}