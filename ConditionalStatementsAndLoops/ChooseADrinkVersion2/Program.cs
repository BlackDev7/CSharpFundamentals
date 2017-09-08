using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrinkVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            switch (profession)
            {
                case "Athlete":
                    price = quantity * 0.70;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, price);
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = quantity * 1.00;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, price);
                    break;
                case "SoftUni Student":
                    price = quantity * 1.70;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, price);
                    break;
                default:
                    price = quantity * 1.20;
                    Console.WriteLine("The {0} has to pay {1:F2}.", profession, price);
                    break;
            }
        }
    }
}
