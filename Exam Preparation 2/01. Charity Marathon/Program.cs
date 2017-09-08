using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runnersCount = long.Parse(Console.ReadLine());
            var averageLapCount = int.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());
            long maximumRunners = marathonDays * trackCapacity;
            if (maximumRunners >= runnersCount)
            {
                    maximumRunners = runnersCount;     
            }
            var totalKm = maximumRunners * averageLapCount * trackLenght / 1000;
            var moneyRaised = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
