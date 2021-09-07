namespace WowApp.Model.Weapon
{
    public interface IWeapon
    {
        int Id { get; }

        string Title { get; }

        string Cover { get; }

        int EnhanceLevel { get; }

        int RequiredLevel { get; }

        int Damage { get; }

        float ReloadTime { get; }

        WeaponType Type { get; }

        int Weight { get; }

        int BuyPrice { get; }

        int SalePrice { get; }
    }
}