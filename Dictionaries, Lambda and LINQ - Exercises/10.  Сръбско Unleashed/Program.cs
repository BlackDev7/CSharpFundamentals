using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> venueSingersPrice = new Dictionary<string, Dictionary<string, long>>();
            var line = Console.ReadLine();
            while (line != "End")
            {
                var tokens = line.Split('@');
                if (tokens[0].EndsWith(" "))
                {
                    string singerName = tokens[0].Remove(tokens[0].Length - 1);
                    var venuePrices = tokens[1].Split();
                    if (venuePrices.Length < 3)
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                    var ticketsPrice = 0;
                    var ticketsCount = 0;

                    try
                    {
                        ticketsCount = int.Parse(venuePrices[venuePrices.Length - 1]);
                        ticketsPrice = int.Parse(venuePrices[venuePrices.Length - 2]);
                        var ticketsTotalPrice = ticketsCount * ticketsPrice;

                        string venue = "";
                        for (int i = 0; i < venuePrices.Length - 2; i++)
                        {
                            venue +=  venuePrices[i] + " ";
                        }
                        venue.Remove(venue.Length - 1);

                        if (!venueSingersPrice.ContainsKey(venue))
                        {
                            venueSingersPrice[venue] = new Dictionary<string, long>();
                        }
                        if (!venueSingersPrice[venue].ContainsKey(singerName))
                        {
                            venueSingersPrice[venue].Add(singerName, 0);
                        }
                        venueSingersPrice[venue][singerName] += ticketsTotalPrice;

                        line = Console.ReadLine();
                        continue;
                    }
                    catch 
                    {
                        line = Console.ReadLine();
                        continue;
                    }
                }
                line = Console.ReadLine();
            }
            foreach (var venue in venueSingersPrice)
            {
                var venueName = venue.Key;
                Console.WriteLine(venueName);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }
    }
}
