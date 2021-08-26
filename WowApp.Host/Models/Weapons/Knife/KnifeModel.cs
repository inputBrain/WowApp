using System;

namespace WowApp.Host.Models.Weapons.Knife
{
    public class KnifeModel : IKnife
    {
        public int Id { get; set; }
        public string Color { get; set; }


        public void GetInfo(KnifeModel model, bool isFullInfo = false)
        {
            // if (isFullInfo){ ... }

            Console.WriteLine($"Knife color: {model.Color}");
        }
    }
}