namespace WowApp.Database.Service
{
    // Читать в UserService.
    public interface IServiceContainer
    {
        IUserService UserService { get; }
        IWeaponService WeaponService { get; }

        IArmorService ArmorService { get; }
    }
}