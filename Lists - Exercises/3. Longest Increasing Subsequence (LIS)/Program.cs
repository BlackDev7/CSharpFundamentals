using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Longest_Increasing_Subsequence__LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] lenght = new int[numbers.Count()];
            int[] previous = new int[numbers.Count()];

            int bestLenght = 0;
            int lastIndex = -1;

            for (int anchor = 0; anchor < numbers.Count(); anchor++)
            {
                lenght[anchor] = 1;
                previous[anchor] = -1;

                int anchorNum = numbers[anchor];

                for (int i = 0; i < anchor; i++)
                {
                    int currentNum = numbers[i];
                    if(currentNum < anchorNum && lenght[i] + 1 > lenght[anchor])
                    {
                        lenght[anchor] = lenght[i] + 1;
                        previous[anchor] = i;
                    }
                }
                if(lenght[anchor] > bestLenght)
                {
                    bestLenght = lenght[anchor];
                    lastIndex = anchor;
                }

            }

            List<int> longestSequence = new List<int> { };

            while(lastIndex != -1)
            {
                longestSequence.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestSequence.Reverse();
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
