using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
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

            numbersCount = numbersCount.OrderByDescending(pair => pair.Value).Take(1)
               .ToDictionary(pair => pair.Key, pair => pair.Value);


            Console.WriteLine(string.Join(" ", numbersCount.Values));



        }
    }
}