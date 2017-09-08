using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var encryptedMessage = Console.ReadLine();
            string encryptedMessageWithoutDigits = Regex.Replace(encryptedMessage, @"\d", "");
            List<int> numbersFromEncryptedMessage = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            Regex regex = new Regex(@"\d");
            foreach (Match match in regex.Matches(encryptedMessage))
            {
                numbersFromEncryptedMessage.Add(int.Parse(match.Value));
            }

            int currentIndex = 0;
            foreach (var digit in numbersFromEncryptedMessage)
            {
                if (currentIndex % 2 == 0)
                {
                    takeList.Add(digit);
                    currentIndex++;
                }
                else
                {
                    skipList.Add(digit);
                    currentIndex++;
                }
            }
            string decryptedMessage = null;
            var total = 0;
            for (int i = 0; i < skipList.Count; i++)
            {
                int skipCount = skipList[i];
                int takeCount = takeList[i];
                decryptedMessage += new string(encryptedMessageWithoutDigits.Skip(total).Take(takeCount).ToArray());
                total += skipCount + takeCount;
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
