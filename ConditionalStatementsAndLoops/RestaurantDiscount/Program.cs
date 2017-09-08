using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string suitableHall = "";
            double totalPrice = 0;

            if(groupSize <= 50 )
            {
                suitableHall = "Small Hall";
                totalPrice = 2500;
            }
            if (groupSize > 50 && groupSize <= 100)
            {
                suitableHall = "Terrace";
                totalPrice = 5000;
            }
            if (groupSize > 100 && groupSize <= 120)
            {
                suitableHall = "Great Hall";
                totalPrice = 7500;
            }

            switch (package)
            {
                case "Normal":
                    totalPrice += 500;
                    totalPrice *= 0.95;
                    break;
                case "Gold":
                    totalPrice += 750;
                    totalPrice *= 0.9;
                    break;
                case "Platinum":
                    totalPrice += 1000;
                    totalPrice *= 0.85;
                    break;
            }



            if (groupSize > 120)
                Console.WriteLine("We do not have an appropriate hall.");
            else
                Console.WriteLine("We can offer you the {0}\nThe price per person is {1:F2}$", suitableHall, totalPrice / groupSize);


        }
    }
}
