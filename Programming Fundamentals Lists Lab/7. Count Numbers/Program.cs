using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();


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
            numbersCount =  numbersCount.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            foreach (var numCount in numbersCount)
            {
                Console.WriteLine(string.Join(" => ", numCount.Key, numCount.Value));
            }
            

        }
    }
}
