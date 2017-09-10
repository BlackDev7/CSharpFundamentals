using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            // [^\w-]+ -> Match anything but words and - 
            // [\w]+-[\w]+ -> Match all pokewords
            var input = Console.ReadLine();
            Regex didiRegex = new Regex(@"[^A-Za-z-]+");
            Regex bojoRegex = new Regex(@"[A-Za-z]+-[A-Za-z]+");
            while (true)
            {
                Match didiMatch = didiRegex.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value);
                }
                else
                {
                    return;
                }

                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                Match bojoMatch = bojoRegex.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value);
                }
                else
                {
                    return;
                }
                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);
            }
        }
    }
}
