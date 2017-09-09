using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var ordersCount = int.Parse(Console.ReadLine());
            List<decimal> coffeePrices = new List<decimal>();
            for (int i = 0; i < ordersCount; i++)
            {
                ReadOrder(coffeePrices);
            }
            decimal totalSum = 0;
            foreach (var coffeeSold in coffeePrices)
            {
                Console.WriteLine($"The price for the coffee is: ${coffeeSold:F2}");
                totalSum += coffeeSold;
            }
            Console.WriteLine($"Total: ${totalSum:F2}");
        }

        private static void ReadOrder(List<decimal> coffeePrices)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            var orderDate = Console.ReadLine().Split('/').Select(int.Parse).ToList();
            var capsulesCount = long.Parse(Console.ReadLine());
            var daysInMonth = DateTime.DaysInMonth(orderDate[2], orderDate[1]);
            decimal priceofCoffee = pricePerCapsule * (daysInMonth * capsulesCount);
            coffeePrices.Add(priceofCoffee);
        }
    }
}
