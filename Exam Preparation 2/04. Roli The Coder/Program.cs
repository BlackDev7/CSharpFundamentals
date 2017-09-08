using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            Dictionary<int, Dictionary<string, List<string>>> eventsParticipants = new Dictionary<int, Dictionary<string, List<string>>>();
            while (line != "Time for Code")
            {
                ReadInput(line, eventsParticipants);
                line = Console.ReadLine();
            }
            PrintEvents(eventsParticipants);
        }

        private static void PrintEvents(Dictionary<int, Dictionary<string, List<string>>> eventsParticipants)
        {
            var sorted = eventsParticipants.OrderByDescending(x => x.Value.Values.First().Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Value.First().Key} - {kvp.Value.Values.First().Count}");
                foreach (var eventKVP in kvp.Value.Values)
                {
                    var sortedEventKvp = eventKVP.OrderBy(x => x);
                    foreach (var participant in sortedEventKvp)
                    {
                        Console.WriteLine($"@{participant}");
                    }
                }
            }
        }

        private static void ReadInput(string line, Dictionary<int, Dictionary<string, List<string>>> eventsParticipants)
        {
            Regex regex = new Regex(@"\b([\d]) #([\w\'\-])+\b");
            if (regex.IsMatch(line))
            {
                var tokens = line.Split().ToArray();
                var id = int.Parse(tokens[0]);
                var eventName = tokens[1].Substring(1, tokens[1].Length - 1);
                List<string> participants = new List<string>();
                Regex regex2 = new Regex(@"@([\w\'\-])+");
                MatchCollection matches = regex2.Matches(line);
                foreach (Match match in matches)
                {
                    participants.Add(match.Value.Substring(1, match.Value.Length - 1));
                }

                if (eventsParticipants.ContainsKey(id) && eventsParticipants[id].ContainsKey(eventName))
                {
                    foreach (var participant in participants)
                    {
                        if (!eventsParticipants[id][eventName].Contains(participant))
                        {
                            eventsParticipants[id][eventName].Add(participant);
                        }
                    }
                }
                else if(!eventsParticipants.ContainsKey(id))
                {
                    eventsParticipants[id] = new Dictionary<string, List<string>>{{eventName, participants}};
                }
            }

        }
    }
}
