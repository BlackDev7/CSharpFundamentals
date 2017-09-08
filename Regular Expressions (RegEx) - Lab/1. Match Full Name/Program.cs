using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex regex = new Regex(@"\b([A-Z][a-z]+) [A-Z][a-z]+\b");
            MatchCollection matchedNames = regex.Matches(input);
            List<string> names = new List<string>();
            foreach (Match match in matchedNames)
            {
                names.Add(match.Value);
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
