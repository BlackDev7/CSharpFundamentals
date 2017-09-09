using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            MatchCollection matches = Regex.Matches(input, @".*?(\d+)");
            for (int i = 0; i < matches.Count; i++)
            {
                var timesToRepeat = int.Parse(matches[i].Groups[1].Value);
                var tempString = Regex.Replace(matches[i].Value, @"\d", "");
                string repeatString = string.Concat(Enumerable.Repeat(tempString, timesToRepeat));
                output.Append(repeatString.ToUpper());
            }
            var unique = output.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {unique}\r\n{output}");
        }
    }
}
