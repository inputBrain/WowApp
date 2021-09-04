namespace WowApp.Model.Armor
{
    public interface IArmor
    {
        int Id { get; }
        string Title { get; }
        float Defence { get; }
        float Weight { get; }
        float TemperatureProtection { get; }
        ArmorType Type { get; }
    }
}