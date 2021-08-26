using System;

namespace WowApp.Host.Models.Weapons.Axe
{
    public class AxeModel : IAxe
    {
        public int Id { get; set; }
        public string Color { get; set; }


        public AxeModel CreateAxe(string color)
        {
            return new AxeModel()
            {
                Color = color
            };
        }


        public string GetInfo(AxeModel model, bool isFullInfo = true)
        {
            // if (isFullInfo){ ... }

            return new string($"Axe color: {model.Color}");
        }
    }
}