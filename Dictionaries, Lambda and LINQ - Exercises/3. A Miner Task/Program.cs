using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> resourcesQuantities = new Dictionary<string, decimal> { };

            string line = Console.ReadLine();

            while (line != "stop")
            {
                string resource = line;
                decimal resourceQuantity = decimal.Parse(Console.ReadLine());

                if (!(resourcesQuantities.ContainsKey(resource)))
                {
                    resourcesQuantities[resource] = resourceQuantity;
                }
                else
                {
                    resourcesQuantities[resource] += resourceQuantity;
                }

                line = Console.ReadLine();
            }
            foreach (var res in resourcesQuantities)
            {
                Console.WriteLine(res.Key + " -> " + res.Value);
            }
        }
    }
}
