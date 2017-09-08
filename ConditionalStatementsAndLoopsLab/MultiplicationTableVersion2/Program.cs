using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplicationStartsFrom = int.Parse(Console.ReadLine());

            if(multiplicationStartsFrom == 0)
                Console.WriteLine("{0} X 0 = 0", number);
            else if(multiplicationStartsFrom > 0 && multiplicationStartsFrom < 10)
            {
                for (int i = multiplicationStartsFrom; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
                }
            }
            else
                Console.WriteLine("{0} X {1} = {2}", number, multiplicationStartsFrom, number * multiplicationStartsFrom);

        }
    }

}
