using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { };

            int numberCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbers.Add(currentNum);
            }

            Console.WriteLine("Sum = " + numbers.Sum() + 
                "\r\nMin = " + numbers.Min() +
                "\r\nMax = " + numbers.Max() +
                "\r\nAverage = " + numbers.Average());

        }
    }
}
