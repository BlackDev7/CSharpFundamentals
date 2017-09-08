using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            AddingZeroesAndPrinting(firstNumber);
            AddingZeroesAndPrinting(secondNumber);
            AddingZeroesAndPrinting(thirdNumber);
            AddingZeroesAndPrinting(forthNumber);

        }

        static void AddingZeroesAndPrinting(int number)
        {
            string checkingNumber = number.ToString();
            switch(checkingNumber.Length)
            {
                case 1:
                    checkingNumber = "000" + number;
                    break;
                case 2:
                    checkingNumber = "00" + number;
                    break;
                case 3:
                    checkingNumber = "0" + number;
                    break;
                default:
                    break;
            }
            Console.Write(checkingNumber + " ");
        }


    }
}
