using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIn30
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            Adding30ToTimeAndPrinting(hours, minutes);

        }

        static void Adding30ToTimeAndPrinting(int hours, int minutes)
        {
            minutes += 30;
            if(minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            if(minutes < 10)
                Console.WriteLine("{0}:0{1}", hours, minutes);
            else
                Console.WriteLine("{0}:{1}", hours, minutes);

        }


    }
}
