namespace WowApp.Database.Service
{
    internal class ServiceContainer : IServiceContainer
    {
        public IUserService User { get; }
        public IArmorService Armor { get; }
        public IWeaponService Weapon { get; }


        public ServiceContainer(
            IUserService userService,
            IArmorService armorService,
            IWeaponService weaponService
        )
        {
            User = userService;
            Armor = armorService;
            Weapon = weaponService;
        }
    }
}