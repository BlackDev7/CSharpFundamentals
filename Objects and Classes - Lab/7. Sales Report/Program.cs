using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                sales.Add(ReadSale());
            }
            foreach (var sale in sales)
            {
                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown.Add(sale.Town, 0);
                }
                salesByTown[sale.Town] += sale.Price * sale.Quantity;
            }
            PrintSales(salesByTown);
        }

        private static void PrintSales(SortedDictionary<string, decimal> salesByTown)
        {
            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }
        private static Sale ReadSale()
        {
            var tokens = Console.ReadLine().Split();
            var town = tokens[0];
            var product = tokens[1];
            var price = decimal.Parse(tokens[2]);
            var quantity = decimal.Parse(tokens[3]);
            return new Sale(){ Town = town, Product = product, Price = price, Quantity = quantity};
        }
    }
}
