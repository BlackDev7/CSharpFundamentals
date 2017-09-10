using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberInput = int.Parse(Console.ReadLine());
            BigInteger factorial = numberInput;
            for (int i = 1; i < numberInput; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
