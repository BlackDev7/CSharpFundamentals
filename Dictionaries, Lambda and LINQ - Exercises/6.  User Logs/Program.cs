using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _6.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userIpCount = new SortedDictionary<string, Dictionary<string, int>>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();
                string ip = tokens[0];
                string user = tokens[2]; 
                string ipFiltered = ip.Substring(3);
                string userFiltered = user.Substring(5);

                if (!userIpCount.ContainsKey(userFiltered))
                {
                    userIpCount[userFiltered] = new Dictionary<string, int>
                    {
                        { ipFiltered, 1 }
                    };
                }
                else
                {
                    if (userIpCount[userFiltered].ContainsKey(ipFiltered))
                    {
                        userIpCount[userFiltered][ipFiltered]++;
                    }
                    else
                    {
                        userIpCount[userFiltered].Add(ipFiltered, 1);
                    }
                }

                line = Console.ReadLine(); 
            }
            foreach (var user in userIpCount.Keys)
            {
                string username = user;
                Dictionary<string, int> ips = userIpCount[username];
                string ipString = "";
                Console.WriteLine($"{username}: ");
                foreach (var ip in ips)
                {
                    ipString += $"{ip.Key} => {ip.Value}, ";
                }
                ipString = ipString.Substring(0, ipString.Length - 2);
                ipString += ".";
                Console.WriteLine(ipString);
            }
        }
    }
}
