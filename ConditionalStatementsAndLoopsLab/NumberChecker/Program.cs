using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            if (int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("It is a number.");
            else
                Console.WriteLine("Invalid input!");
        }
    }
}
