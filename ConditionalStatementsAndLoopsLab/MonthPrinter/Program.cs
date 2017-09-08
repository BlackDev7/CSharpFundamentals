using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthNumber = int.Parse(Console.ReadLine());
            string[] months = new string[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

            if(monthNumber > 0 && monthNumber <= 12)
                Console.WriteLine(months[monthNumber - 1]);
            else
                Console.WriteLine("Error!");
        }
    }
}
