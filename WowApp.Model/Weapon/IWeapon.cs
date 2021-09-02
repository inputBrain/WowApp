namespace WowApp.Model.Weapon
{
    public interface IWeapon
    {
        int Id { get; }
        string Title { get; }
        int Damage { get; }
        float ReloadTime { get; }
        WeaponType Type { get; }
    }
}
