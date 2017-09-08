using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductQuantity { get; set; }
        public decimal Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            List<Customer> customers = new List<Customer>();
            ReadProducts(numberOfProducts, shop);
            TakeOrders(shop, customers);
            PrintResults(customers, shop);
        }

        private static void PrintResults(List<Customer> customers, Dictionary<string, decimal> shop)
        {
            foreach (var customer in customers)
            {
                foreach (var item in customer.ProductQuantity)
                {

                    foreach (var product in shop)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }
            var sortedCustomers = customers.OrderBy(x => x.Name).ThenBy(x => x.Bill).ToList();
            decimal totalBill = 0;
            foreach (var customer in sortedCustomers)
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var product in customer.ProductQuantity)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill}");
        }


        private static void TakeOrders(Dictionary<string, decimal> shop, List<Customer> customers)
        {
           var line = Console.ReadLine();
            while (line != "end of clients")
            {
                var tokens = Regex.Split(line, "(-)|(,)");
                var name = tokens[0];
                var product = tokens[2];
                int quantity = int.Parse(tokens[4]);
                if (shop.ContainsKey(product))
                {
                    if (customers.Any(c => c.Name == name))
                    {
                        Customer existingCustomer = customers.First(c => c.Name == name);
                        if (existingCustomer.ProductQuantity.ContainsKey(product))
                        {
                            existingCustomer.ProductQuantity[product] += quantity;
                        }
                        else
                        {
                            existingCustomer.ProductQuantity[product] = quantity;
                        }
                    }
                    else
                    {
                        customers.Add(new Customer { Name = name, ProductQuantity = new Dictionary<string, int>() { { product, quantity } }});
                    }
                }
                line = Console.ReadLine();
            }
        }


        private static void ReadProducts(int numberOfProducts, Dictionary<string, decimal> shop)
        {
            for (int i = 0; i < numberOfProducts; i++)
            {
                var tokens = Console.ReadLine().Split('-');
                var product = tokens[0];
                var price = decimal.Parse(tokens[1]);

                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, price);
                }
                else
                {
                    shop[product] = price;
                }
            }
        }
    }
}
