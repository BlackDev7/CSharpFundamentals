using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> teamsPoints = new Dictionary<string, int>();
            Dictionary<string, int> teamsGoals = new Dictionary<string, int>();
            var key = Console.ReadLine();
            var line = Console.ReadLine();
            while (line != "final")
            {
                ReadLine(line, key, teamsPoints, teamsGoals);
                line = Console.ReadLine();
            }
            PrintResults(teamsPoints, teamsGoals);
        }

        private static void PrintResults(Dictionary<string, int> teamsPoints, Dictionary<string, int> teamsGoals)
        {
            var sortedByPoints = teamsPoints.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var sortedByGoals = teamsGoals.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var top3Goals = sortedByGoals.Take(3);
            Console.WriteLine($"League standings:");
            for (int i = 1; i <= sortedByPoints.Count(); i++)
            {
                Console.WriteLine($"{i}. {sortedByPoints.ElementAt(i-1).Key} {sortedByPoints.ElementAt(i - 1).Value}");
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in top3Goals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        private static void ReadLine(string line, string key, Dictionary<string, int> teamsPoints, Dictionary<string, int> teamsGoals)
        {
            var escapedKey = Regex.Escape(key);
            MatchCollection teamsMatch = Regex.Matches(line, @"(?<=" + escapedKey + @")\w+(?=" + escapedKey + ")");
            Match teamAMatch = teamsMatch[0];
            Match teamBMatch = teamsMatch[1];
            string teamA = new string(teamAMatch.Value.ToCharArray().Reverse().ToArray());
            string teamB = new string(teamBMatch.Value.ToCharArray().Reverse().ToArray());
            teamA = teamA.ToUpper();
            teamB = teamB.ToUpper();
            MatchCollection goals = Regex.Matches(line, @"\d");
            var goalsA = int.Parse(goals[0].Value);
            var goalsB = int.Parse(goals[1].Value);
            if (teamsGoals.ContainsKey(teamA))
            {
                teamsGoals[teamA] += goalsA;
            }
            else
            {
                teamsGoals[teamA] = goalsA;
            }
            if (teamsGoals.ContainsKey(teamB))
            {
                teamsGoals[teamB] += goalsB;

            }
            else
            {
                teamsGoals[teamB] = goalsB;
            }
            foreach (var team in teamsGoals)
            {
                if (!teamsPoints.ContainsKey(team.Key))
                {
                    teamsPoints[team.Key] = 0;
                }
                
            }
            if (goalsA > goalsB)
            {
                teamsPoints[teamA] += 3;
            }
            else if (goalsA < goalsB)
            {
                teamsPoints[teamB] += 3;
            }
            else if(goalsA == goalsB)
            {
                teamsPoints[teamA] += 1;
                teamsPoints[teamB] += 1;
            }
        }
    }
}
