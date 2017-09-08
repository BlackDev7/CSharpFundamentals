using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();
            var input = Console.ReadLine();
            while (input != "stocked")
            {
                var tokens = input.Split();
                var productName = tokens[0];
                var productPrice = double.Parse(tokens[1]);
                int productQuantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(productName))
                {
                    products[productName] = new Dictionary<double, int>();
                }
                if (!products[productName].ContainsKey(productPrice))
                {
                    products[productName][productPrice] = productQuantity;
                    if (products[productName].Count() > 1)
                    {
                        var totalQuantity = products[productName].Values.Sum();
                        products[productName].Clear();
                        products[productName][productPrice] = totalQuantity;
                    }
                }
                input = Console.ReadLine();
            }
            double grandTotal = 0;
            foreach (var product in products)
            {
                var nameOfProduct = product.Key;
                double productPrice = product.Value.Keys.First();
                int productQuantity = product.Value.Values.First();
                grandTotal += productPrice * productQuantity;
                Console.WriteLine($"{nameOfProduct}: ${productPrice:f2} * {productQuantity} = ${productQuantity * productPrice:f2}");  
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Grand Total: ${0:f2}", grandTotal);
        }
    }
}
