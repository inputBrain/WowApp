namespace WowApp.Model.User
{

    // Базовый интерфейс модельки User. Этот интерфейс описывает нашу модельку
    // Здесь не должно быть ничего кроме самих полей
    public interface IUser
    {
        string Nickname { get; }
        float Hp { get; }
        uint Level { get; }
        float Experience { get; }
    }
}