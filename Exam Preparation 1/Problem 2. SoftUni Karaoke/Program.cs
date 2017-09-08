using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = new List<string>();
            List<string> avaivableSongs = new List<string>();
            Dictionary<string, List<string>> performersAwards = new Dictionary<string, List<string>>();

            participants.AddRange(Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries));
            avaivableSongs.AddRange(Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
            var line = Console.ReadLine();
            while (line != "dawn")
            {
                ReadPerformers(participants, avaivableSongs, performersAwards, line);
                line = Console.ReadLine();
            }
            PrintPerformersAwards(performersAwards);
        }

        private static void PrintPerformersAwards(Dictionary<string, List<string>> performersAwards)
        {
            var sortedPerformers = performersAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            if (sortedPerformers.Count > 0)
            {
                foreach (var performer in sortedPerformers)
                {
                    var performerName = performer.Key;
                    var awardsCount = performer.Value.Count;
                    Console.WriteLine($"{performerName}: {awardsCount} awards");
                    performer.Value.Sort();
                    foreach (var award in performer.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
          
        }

        private static void ReadPerformers(List<string> participants, List<string> avaivableSongs, Dictionary<string, List<string>> performersAwards, string line)
        {
            var tokens = line.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var performerName = tokens[0];
            var songPerforming = tokens[1];
            var award = tokens[2];
            if (participants.Contains(performerName) && avaivableSongs.Contains(songPerforming))
            {
                if (!performersAwards.ContainsKey(performerName))
                {
                    performersAwards[performerName] = new List<string>{award};
                }
                else
                {
                    if (!performersAwards[performerName].Contains(award))
                    {
                        performersAwards[performerName].Add(award);
                    }
                }
            }
        }
    }
}
