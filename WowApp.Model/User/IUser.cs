namespace WowApp.Model.User
{
    public interface IUser
    {
        int Id { get; }

        string Nickname { get; }

        int Hp { get; }

        int Experience { get; }

        int Level { get; }
    }
}