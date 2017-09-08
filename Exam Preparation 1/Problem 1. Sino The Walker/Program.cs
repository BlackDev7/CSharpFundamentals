using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTime = Console.ReadLine().Split(':').Select(long.Parse).ToArray();
            var numberOfSteps = long.Parse(Console.ReadLine());
            var timeForEachStep = long.Parse(Console.ReadLine());
            var secondsToAdd = numberOfSteps * timeForEachStep;

            long startTimeInSeconds = startTime[0] * 3600 + 60 * startTime[1] + startTime[2];
            long arrivalTimeInSeconds = startTimeInSeconds +  secondsToAdd;

            var hours = arrivalTimeInSeconds / 3600 % 24;
            var minutes = (arrivalTimeInSeconds % 3600) / 60;
            var seconds = (arrivalTimeInSeconds % 60);

            Console.WriteLine($"Time Arrival: {hours:D2}:{minutes:D2}:{seconds:D2}");

        }
    }
}
