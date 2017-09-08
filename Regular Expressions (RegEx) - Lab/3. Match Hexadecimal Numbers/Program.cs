using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            List<string> hexNumbers = new List<string>();
            Regex regex = new Regex(@"\b[0x?[0-9A-F]+\b");
            MatchCollection matches = regex.Matches(line);
            foreach (Match match in matches)
            {
                hexNumbers.Add(match.Value);
            }
            Console.WriteLine(string.Join(" ", hexNumbers));
        }
    }
}
