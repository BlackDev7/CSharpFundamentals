using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0)
                Console.WriteLine("{0}$", CalculatingPrice(typeOfDay, age));
            else
                Console.WriteLine("Error!");
        }

        static int CalculatingPrice(string typeOfDay, int age)
        {
            int price = 0;

            switch(typeOfDay)
            {

                case "Weekday":
                    if (age >= 0 && age <= 18)
                        price = 12;
                    else if (age >= 19 && age <= 64)
                        price = 18;
                    else if (age >= 65 && age <= 122)
                        price = 12;
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                        price = 15;
                    else if (age >= 19 && age <= 64)
                        price = 20;
                    else if (age >= 65 && age <= 122)
                        price = 15;
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                        price = 5;
                    else if (age >= 19 && age <= 64)
                        price = 12;
                    else if (age >= 65 && age <= 122)
                        price = 10;
                    break;
            }

            return price;
        }
    }
}
