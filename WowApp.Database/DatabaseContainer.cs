using WowApp.Database.User;
using WowApp.Database.Weapon;

namespace WowApp.Database
{
    // Этот класс нужен для создания объектов на глобальном уровне. На глобальном уровне в плане того, что
    // в этом месте будут создаваться  наш(-ы) объекты и мы сможем через интерфейсы которые описаны ниже
    // использовать нужный нам функционал. Нужно помнить о том, что мы будем обращаться к интерфейсам
    // и если в интерфейсе не будет описан нужный нам функционал, то мы не сможем его использовать.
    internal class DatabaseContainer : IDatabaseContainer
    {
        public IUserRepository User { get; }
        public IWeaponRepository Weapon { get; }


        public DatabaseContainer(
            IUserRepository user,
            IWeaponRepository weapon
        )
        {
            User = user;
            Weapon = weapon;
        }
    }
}