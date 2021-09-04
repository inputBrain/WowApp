using System;

namespace WowApp.Model.Clothing
{
    public interface IClothing
    {
        int Id { get; }
        string Title { get; }
        float Defence { get; }
        float Weight { get; }
        float TemperatureProtection { get; }
        ClothingType Type { get; }
    }
}