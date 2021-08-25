using System;
using WowApp.Host.Interfaces;
using WowApp.Host.Objects;
using WowApp.Host.Objects.Box;
using WowApp.Host.Objects.Items;

namespace WowApp.Host
{

        public class Program
        {
            public static void Main()
            {
                StandartObject[] inventory = { new Box(), new Chest(), new Pickaxe()};

                foreach (var obj in inventory)
                {
                    GetInformation(obj, "Full");
                }
                Console.WriteLine($"\n");
                inventory[0].Name = "Коробка второго уровня";

                foreach (var obj in inventory)
                {
                    GetInformation(obj, "!Full");
                }
                Console.ReadLine();
            }

            static public void GetInformation(IGetInfo obj, string typeInfo)
            {
                obj.ShowInfo(typeInfo);
            }
        }
}