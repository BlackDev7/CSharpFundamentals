using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = { ',', ';', ':', '.', '!', '(', ')', '\'', '\"', '\\', '/', '[', ']', ' ' };
            List<string> words = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>{ };
            List<string> upperCaseWords = new List<string> { };
            List<string> mixedCaseWords = new List<string> { };

            foreach (var word in words)
            {
                if(word.All(c => char.IsUpper(c)))
                {
                    upperCaseWords.Add(word);
                }
                else if(word.All(c => char.IsLower(c)))
                {
                    lowerCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }

            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));

        }
    }
}
