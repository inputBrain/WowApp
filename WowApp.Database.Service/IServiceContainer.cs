namespace WowApp.Database.Service
{
    public interface IServiceContainer
    {
        IUserService User { get; }
        IArmorService Armor { get; }
        IWeaponService Weapon { get; }
    }
}