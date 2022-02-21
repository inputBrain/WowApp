using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WowApp.Host.Controllers.Admin
{
    public class GiftController : AbstractAdminController<GiftController>
    {
        public GiftController(ILogger<GiftController> logger) : base(logger)
        {
        }
        
        
        [HttpGet]
        public void GetGiftByChance(int chance = 1)
        {
            const int attempts = 9999999;

            var gift = 0;
            var boxNumber = 0;
            var firstBox = 0;
            var boxNumberCollection = new List<int>();
            var random = new Random();

            do
            {
                boxNumber++;
                var randomChance = random.Next(0, 100);
                if (randomChance <= chance)
                { 
                    gift++;
                    boxNumberCollection.Add(boxNumber);
                    if (boxNumber == 1)
                    {
                        firstBox++;
                    }
                    // Console.WriteLine($"Success! Box number #: {boxNumber}. You got the gift");
                    boxNumber = 0;
                }
            } while (gift <= attempts);

            var avg = boxNumberCollection.Average();
            Console.WriteLine($"In average, you need to open: {avg} boxes to get the gift.");
            Console.WriteLine($"\n You got the gift from the first box: {firstBox:N1} times of {attempts + 1:N1} attempts. Failed: {attempts + 1 - firstBox:N1} boxes");
        }
    }
}