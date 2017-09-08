using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText(@"C:\Users\kiko0735\Desktop\10. Programming-Fundamentals-Objects-Classes-Files-and-Exceptions-More-Exercises-Resources\sample_text.txt");
            var matches = Regex.Matches(file, @"[,]|[.]|[!]|[?]|[:]");
            List<string> separators = new List<string>();
            foreach (var match in matches)
            {
                separators.Add(match.ToString());
            }
            Console.WriteLine(string.Join(", ", separators));
        }
    }
}
