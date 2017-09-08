using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<string> filteredHexInput = new List<string>();
            Regex regex = new Regex(@"\b[(A-Za-z0-9)]{2}\b");
            Match match = regex.Match(input);
            foreach (Match m in regex.Matches(input))
            {
                var reversedMatch = new string(m.Value.Reverse().ToArray());
                filteredHexInput.Add(reversedMatch);
            }
            filteredHexInput.Reverse();
            foreach (var hex in filteredHexInput)
            {
                var value = Convert.ToInt32(hex, 16);
                Console.Write((char)value);
            }
            
        }
    }
}
