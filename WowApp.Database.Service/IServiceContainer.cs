namespace WowApp.Database.Service
{
    public interface IServiceContainer
    {
        IUserService User { get; }
    }
}