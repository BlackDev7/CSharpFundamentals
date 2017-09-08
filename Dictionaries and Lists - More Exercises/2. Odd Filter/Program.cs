using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numbersWithoutOdd = input.Select(int.Parse).Where(x => x % 2 == 0).ToList();

            for (int i = 0; i < numbersWithoutOdd.Count; i++)
            {
                int currentNumber = numbersWithoutOdd[i];
                if (currentNumber > numbersWithoutOdd.Average())
                {
                    numbersWithoutOdd[i]++;
                }
                else
                {
                    numbersWithoutOdd[i]--;
                }
            }

            Console.WriteLine(string.Join(" ", numbersWithoutOdd));
        }
    }
}
