using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var driverNames = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var checkpointIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var driver in driverNames)
            {
                CalculateFuel(driver, zones, checkpointIndexes);
            }
        }

        private static void CalculateFuel(string driver, decimal[] zones, int[] checkpointIndexes)
        {
            decimal startingFuel = driver[0];
            decimal currentFuel = startingFuel;
            for (int i = 0; i < zones.Length; i++)
            {
                if (checkpointIndexes.Contains(i))
                {
                    currentFuel += zones[i];
                }
                else
                {
                    currentFuel -= zones[i];
                }
                if (currentFuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {i}");
                    break;
                }
            }
            if (currentFuel > 0)
            {
                Console.WriteLine($"{driver} - fuel left {currentFuel:F2}");
            }
        }
    }
}
