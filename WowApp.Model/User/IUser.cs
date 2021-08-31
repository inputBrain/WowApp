namespace WowApp.Model.User
{
    public interface IUser
    {
        int Id { get; }

        string FirstName { get; }

        string LastName { get; }

        string Cover { get; }

        UserRole Role { get; }
    }
}