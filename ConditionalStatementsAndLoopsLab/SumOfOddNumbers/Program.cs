using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOdd = int.Parse(Console.ReadLine());
            int sumOfOdd = 0;

            for (int i = 1; i <= countOfOdd; i++)
            {
                if (i == 1)
                    Console.WriteLine(1);
                else
                {
                    Console.WriteLine(i + 1);
                    sumOfOdd += i + 2;  

                }
            }

            Console.WriteLine("Sum: {0}", sumOfOdd);
        }
    }
}
