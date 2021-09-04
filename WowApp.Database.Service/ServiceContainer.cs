namespace WowApp.Database.Service
{
    // Читать в UserService.
    internal class ServiceContainer : IServiceContainer
    {
        public IUserService UserService { get; }
        public IWeaponService WeaponService { get; }
        public IArmorService ArmorService { get; }


        public ServiceContainer
        (
            IUserService userService,
            IWeaponService weaponService,
            IArmorService armorService
        )
        {
            UserService = userService;
            WeaponService = weaponService;
            ArmorService = armorService;
        }
    }
}