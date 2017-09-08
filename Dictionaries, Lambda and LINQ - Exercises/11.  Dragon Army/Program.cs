using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<long> > > dragonData = new Dictionary<string, Dictionary<string, List<long>>>();
            var numberOfDragons = int.Parse(Console.ReadLine());//{type} {name} {damage} {health} {armor}. 

            for (int i = 0; i < numberOfDragons; i++)
            {
                string input = Console.ReadLine();
                ManageInput(input, dragonData);
            }
            PrintResults(dragonData);
        }

        private static void PrintResults(Dictionary<string, Dictionary<string, List<long>>> dragonData)
        {
            //{ Type}::({ damage}/{ health}/{ armor})
            foreach (var type in dragonData)
            {
                double averageDamage = type.Value.Select(x => x.Value[0]).Average();
                double averageHealth = type.Value.Select(x => x.Value[1]).Average();
                double averageArmor = type.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine(type.Key + "::({0:f2}/{1:f2}/{2:f2})", averageDamage, averageHealth, averageArmor);
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    //-{Name} -> damage: {damage}, health: {health}, armor: {armor}
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", 
                        dragon.Key ,dragon.Value[0], dragon.Value[1], dragon.Value[2]);
                }
            }
        }

        private static void ManageInput(string input, Dictionary<string, Dictionary<string, List<long>>> dragonData)
        {
            var tokens = input.Split();
            var type = tokens[0];
            var name = tokens[1];

            long damage = 45;
            if (tokens[2] != "null")
            {
                damage = long.Parse(tokens[2]);
            }
            long health = 250;
            if (tokens[3] != "null")
            {
                health = long.Parse(tokens[3]);
            }
            long armor = 10;
            if (tokens[4] != "null")
            {
                armor = long.Parse(tokens[4]);
            }

            if (dragonData.ContainsKey(type))
            {
                if (dragonData[type].ContainsKey(name))
                {
                    dragonData[type][name][0] = damage;
                    dragonData[type][name][1] = health;
                    dragonData[type][name][2] = armor;
                }
                else
                {
                    dragonData[type].Add(name, new List<long> { damage, health, armor });
                }
            }
            else
            {
                dragonData.Add(type, new Dictionary<string, List<long>> { { name, new List<long>() {damage, health, armor} } });
            }
        }
    }
}
