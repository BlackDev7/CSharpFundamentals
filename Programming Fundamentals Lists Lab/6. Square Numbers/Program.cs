using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int> { };

            foreach (var num in numbers)
            {
                if(Math.Sqrt(num) % 1 == 0)
                {
                    squareNumbers.Add(num);
                }
            }
            squareNumbers = squareNumbers.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
