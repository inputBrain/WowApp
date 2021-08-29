namespace WowApp.Model.Models.User
{

    // Базовый интерфейс модельки User. Этот интерфейс описывает нашу модельку
    // Здесь не должно быть ничего кроме самих полей
    public interface IUser
    {
        int Id { get; }

        string FirstName { get; }

        string LastName { get; }

        string Cover { get; }

        UserRole Role { get; } // Enum - наш кастомный массив.
    }
}