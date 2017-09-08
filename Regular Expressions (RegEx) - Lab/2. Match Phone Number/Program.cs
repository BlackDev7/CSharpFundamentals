using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            List<string> phoneNumbers = new List<string>();
            Regex regex = new Regex(@"\b^|[+][359]+(-| )[2]\1[\d]{3}\1[\d]{4}\b");
            MatchCollection matches = regex.Matches(line);
            foreach (Match match in matches)
            {
                phoneNumbers.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ", phoneNumbers));
        }
    }
}
