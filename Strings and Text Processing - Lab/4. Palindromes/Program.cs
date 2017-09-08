using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var palindromes = new List<string>();
            var line = Regex.Split(Console.ReadLine(), @"\W+").ToList();
            foreach (var word in line)
            {
                if (word.SequenceEqual(word.Reverse()) && word != string.Empty)
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x => x)));
        }
    }
}
