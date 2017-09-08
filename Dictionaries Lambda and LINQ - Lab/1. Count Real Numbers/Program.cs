using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();


            foreach (var num in numbers)
            {
                if (numbersCount.ContainsKey(num))
                {
                    numbersCount[num]++;
                }
                else
                {
                    numbersCount[num] = 1;
                }
            }

            foreach (var num in numbersCount)
            {
                Console.WriteLine(num.Key + " -> " + num.Value);
            }
        }
    }
}
