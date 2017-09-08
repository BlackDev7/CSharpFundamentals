using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int number = int.Parse(Console.ReadLine());
                if(Math.Abs(number % 2) != 0)
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(number));
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            } while (true);
        }
    }
}
