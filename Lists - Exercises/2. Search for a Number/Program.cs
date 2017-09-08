using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();

            int numberOfElements = tokens[0];
            int numberToDelete = tokens[1];
            int comparedNumber = tokens[2];


            List<int> result = new List<int> { };

            result = numbers.Take(numberOfElements).Skip(numberToDelete).ToList();
            if(result.Any(x => x == comparedNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
