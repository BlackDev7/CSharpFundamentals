using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string search = Console.ReadLine();
            Regex regexObj = new Regex(search);
            Match matchObj = regexObj.Match(input);
            int count = 0;
            while (matchObj.Success)
            {
                matchObj = regexObj.Match(input, matchObj.Index + 1);
                count++;
            }
            Console.WriteLine();
        }
    }
}
