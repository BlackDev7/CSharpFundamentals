using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Legendary_Farming
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var materialQuantities = new SortedDictionary<string, long>();
            var legendaryMaterial = new SortedDictionary<string, long>();

            legendaryMaterial["shards"] = 0;
            legendaryMaterial["fragments"] = 0;
            legendaryMaterial["motes"] = 0;
            var winner = "";

            var getMaterial = true;

            while (getMaterial)
            {
                var input = Console.ReadLine().Split().ToList();
                for (var i = 0; i < input.Count; i += 2)
                {
                    var quantity = int.Parse(input[i]);
                    var material = input[i + 1].ToLower();

                    if (legendaryMaterial.ContainsKey(material))
                    {
                        legendaryMaterial[material] += quantity;
                        if (legendaryMaterial[material] >= 250)
                        {
                            winner = material;
                            legendaryMaterial[material] -= 250;
                            getMaterial = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!materialQuantities.ContainsKey(material))
                            materialQuantities[material] = 0;
                        materialQuantities[material] += quantity;
                    }
                }
            }

            Console.WriteLine(PrintWinner(winner) + " obtained!");
            var orderedLegendaryMaterial = legendaryMaterial.OrderByDescending(x => x.Value);
            foreach (var item in orderedLegendaryMaterial)
                Console.WriteLine(item.Key + ": " + item.Value);
            foreach (var item in materialQuantities)
                Console.WriteLine(item.Key + ": " + item.Value);
        }

        private static string PrintWinner(string winner)
        {
            switch (winner)
            {
                case "shards":
                    return "Shadowmourne";
                case "motes":
                    return "Dragonwrath";
                case "fragments":
                    return "Valanyr";
            }
            return "";
        }
    }
}
