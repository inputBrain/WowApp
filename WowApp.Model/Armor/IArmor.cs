namespace WowApp.Model.Armor
{
    public interface IArmor
    {
        string Title { get; }
        string Cover { get; }
        int RequiredLevel { get; }
        int PDef { get; }
        int MDef { get; }
        float EnhanceLevel { get; }
        float Weight { get; }
        float BuyPrice { get; }
        float SalePrice { get; }

        ArmorType Type { get; }
        ArmorGrade Grade { get; }
    }
}