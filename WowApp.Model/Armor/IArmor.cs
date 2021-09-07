namespace WowApp.Model.Armor
{
    public interface IArmor
    {
        int Id { get; }

        string Title { get; }

        string Cover { get; }

        int EnhanceLevel { get; }

        ArmorGrade Grade { get; }

        ArmorType Type { get; }

        int RequiredLevel { get; }

        int PDef { get; }

        int MDef { get; }

        int Weight { get; }

        int BuyPrice { get; }

        int SalePrice { get; }
    }
}