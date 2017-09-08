using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = tokens[0];
            int bombPower = tokens[1];

            for (int i = 0; i < numbers.Count(); i++)
            {

                int currentNum = numbers[i];

                if(currentNum == bombNumber)
                {
                    int leftIndex = Math.Max(i - bombPower, 0);
                    int rightIndex = Math.Min(i + bombPower, numbers.Count - 1);

                    int removeCount = rightIndex - leftIndex + 1;
                    numbers.RemoveRange(leftIndex, removeCount);

                    i = -1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
