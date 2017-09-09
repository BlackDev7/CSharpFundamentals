using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountCash = decimal.Parse(Console.ReadLine());
            var guestCount = int.Parse(Console.ReadLine());
            var priceOfBanana = decimal.Parse(Console.ReadLine());
            var priceOfEgg = decimal.Parse(Console.ReadLine());
            var priveOfBerryForKilo = decimal.Parse(Console.ReadLine());
            var dessertCount = 0;

            if (guestCount > 0)
            {
                dessertCount = 1;
                while (guestCount > 6)
                {
                    dessertCount++;
                    guestCount -= 6;
                }
            }
            decimal priceOfSet = 2 * priceOfBanana + 4 * priceOfEgg + 0.2m * priveOfBerryForKilo;
            decimal totalPrice = dessertCount * priceOfSet;
            if (totalPrice <= amountCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice - amountCash:F2}lv more.");
            }
            Console.WriteLine();
        }
    }
}
