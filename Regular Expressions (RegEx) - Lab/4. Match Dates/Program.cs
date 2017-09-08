using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            Regex regex = new Regex(@"\b(\d{2})([\.\-\/])([A-Z][a-z]{2})\2(\d{4})\b");
            MatchCollection matches = regex.Matches(line);
            foreach (Match match in matches)
            {
                var day = match.Groups[1].Value;
                var month = match.Groups[3].Value;  
                var year = match.Groups[4].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
