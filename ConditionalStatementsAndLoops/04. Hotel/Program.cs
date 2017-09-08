using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            double nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50 * nightsCount;
                    doublePrice = 65 * nightsCount;
                    suitePrice = 75 * nightsCount;
                    if (nightsCount >= 7)
                    {
                        if (month == "October")
                        {
                            studioPrice = 50 * (nightsCount - 1);
                        }
                        studioPrice *= 0.95;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 60 * nightsCount;
                    doublePrice = 72 * nightsCount;
                    suitePrice = 82 * nightsCount;

                    if (nightsCount >= 14)
                    {

                        doublePrice *= 0.90;
                    }
                    if (month == "September" && nightsCount >= 7)
                    {
                        studioPrice = 60 * (nightsCount - 1);
                    }

                    break;

                case "July":
                case "August":
                case "December":
                    studioPrice = 68 * nightsCount;
                    doublePrice = 77 * nightsCount;
                    suitePrice = 89 * nightsCount;

                    if (nightsCount >= 14)
                    {
                        suitePrice *= 0.85;
                    }
                    break;
            }

            Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.", studioPrice, doublePrice, suitePrice);

        }
    }
}