using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _8.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> logs = new SortedDictionary<string, Dictionary<string, int>>();

            int inputsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string ip = tokens[0];
                string user = tokens[1];
                string duration = tokens[2];

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new Dictionary<string, int>();
                }
                if (!logs[user].ContainsKey(ip))
                {
                    logs[user].Add(ip, 0);
                }
                logs[user][ip] += int.Parse(duration);
            }

            
            foreach (var log in logs)
            {
                string name = log.Key;
                int totalDuration = log.Value.Values.Sum();
                List<string> ips = log.Value.Keys.OrderBy(x => x).ToList();
                Console.WriteLine("{0}: {1} [{2}]", name, totalDuration, string.Join(", ", ips));
                
            }

        }
    }
}
