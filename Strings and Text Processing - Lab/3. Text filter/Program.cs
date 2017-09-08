using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
            var input = Console.ReadLine();
            StringBuilder textBuilder = new StringBuilder(input);

            foreach (string bannedWord in bannedWords)
            {
                string mask = new string('*', bannedWord.Length);
                textBuilder.Replace(bannedWord, mask);
            }
            Console.WriteLine(textBuilder.ToString());
        }
    }
}
