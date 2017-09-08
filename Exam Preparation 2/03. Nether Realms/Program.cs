using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            List<string> demonNames = line.Split(',').Select(p => p.Trim()).ToList();
            Dictionary<string, Dictionary<int, decimal>> demonHealthDmg = new Dictionary<string, Dictionary<int, decimal>>();
            CalculateHealthDmg(line, demonNames, demonHealthDmg);
            PrintDemons(demonHealthDmg);
        }

        private static void PrintDemons(Dictionary<string, Dictionary<int, decimal>> demonHealthDmg)
        {
            var sortedDemons = demonHealthDmg.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var demon in sortedDemons)
            {
                var demonName = demon.Key;
                var demonHealth = 0;
                decimal demonDmg = 0;
                foreach (var kvp in demon.Value)
                {
                      demonHealth = kvp.Key;
                      demonDmg = kvp.Value;
                }

                Console.WriteLine($"{demonName} - {demonHealth} health, {demonDmg:F2} damage");
            }
        }

        private static void CalculateHealthDmg(string line, List<string> demonNames, Dictionary<string, Dictionary<int, decimal>> demonHealthDmg)
        {
            foreach (var demon in demonNames)
            {
                int health = 0;
                foreach (Match match in Regex.Matches(demon, @"[A-Za-z]"))
                {
                    foreach (char c in match.Value)
                    {
                        health += System.Convert.ToInt32(c);
                    }
                }
                decimal baseDmg = 0;
                foreach (Match match in Regex.Matches(demon, @"[\-]{0,1}[0-9]+[\.][0-9]+|[\-]{0,1}[0-9]+"))
                {
                    baseDmg += Convert.ToDecimal(match.Value);
                }
                foreach (Match match in Regex.Matches(demon, @"[*/]"))
                {
                    if (match.Value == "*")
                    {
                        baseDmg *= 2;
                    }
                    else
                    {
                        baseDmg /= 2;
                    }
                }
                demonHealthDmg[demon] = new Dictionary<int, decimal>() { { health, baseDmg } };
            }
        }
    }
}
