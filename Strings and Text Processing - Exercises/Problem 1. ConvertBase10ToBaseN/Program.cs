using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.ConvertBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            var base10 = int.Parse(line[1]);
            var baseN = int.Parse(line[0]);

            var index = 0;
            var remainder = 0;
            List<int> digit = new List<int>();
            while (base10 != 0)
            {
                remainder = base10 % baseN;  
                base10 /= baseN; 
                digit.Add(remainder);
                index++;
            }
            digit.Reverse();
            Console.WriteLine(string.Join("", digit));
        }
    }
}
