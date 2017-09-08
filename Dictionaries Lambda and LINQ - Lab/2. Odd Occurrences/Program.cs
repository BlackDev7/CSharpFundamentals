using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> numbersCount = new Dictionary<string, int>();

            List<string> oddWords = new List<string> { };

            foreach (var word in words)
            {
                if (numbersCount.ContainsKey(word))
                {
                    numbersCount[word]++;
                }
                else
                {
                    numbersCount[word] = 1;
                }
            }

            foreach (var num in numbersCount)
            {
                if (num.Value % 2 != 0)
                {
                    oddWords.Add(num.Key);
                }

            }

            Console.WriteLine(string.Join(", ", oddWords));
        }
    }
}
