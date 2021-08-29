namespace WowApp.Model.Weapon
{
    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }
        float ReloadTime { get; }
        WeaponType Type { get; }
    }
}
