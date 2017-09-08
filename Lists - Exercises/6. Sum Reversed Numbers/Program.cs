using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                string currentNumberToString = currentNumber.ToString();
                char[] reversedList = currentNumberToString.Reverse().ToArray();
                string reversedNum = new string(reversedList);

                numbers[i] = int.Parse(reversedNum);
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
