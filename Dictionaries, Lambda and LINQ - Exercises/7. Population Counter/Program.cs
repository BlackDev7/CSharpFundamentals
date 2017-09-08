using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countryCityPopulation = new Dictionary<string, Dictionary<string, long>>();

            string line = Console.ReadLine();
            while (line != "report")
            {
                List<string> tokens = line.Split('|').ToList();
                string city = tokens.First();
                string country = tokens.Skip(1).First();
                string population = tokens.Last();

                if (!countryCityPopulation.ContainsKey(country))
                {
                        countryCityPopulation[country] = new Dictionary<string, long>();
                }
                if (!countryCityPopulation[country].ContainsKey(city))
                {
                    countryCityPopulation[country].Add(city, 0);
                }
                countryCityPopulation[country][city] += long.Parse(population);

                line = Console.ReadLine();
                
            }
            Dictionary<string, long> mergeDict = new Dictionary<string, long>();
            foreach (var item in countryCityPopulation)
            {
                mergeDict[item.Key] = item.Value.Values.Sum();
            }
            foreach (var item in mergeDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var index in countryCityPopulation[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{index.Key}: {index.Value}");
                }
            }
        }
    }
}
