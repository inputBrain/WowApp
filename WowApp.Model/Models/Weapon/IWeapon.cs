namespace WowApp.Model.Models.Weapon
{
    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }

        float ReloadTime { get; }
    }
}
