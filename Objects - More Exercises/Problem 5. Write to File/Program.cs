using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_5.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText(@"C:\Users\kiko0735\Desktop\10. Programming-Fundamentals-Objects-Classes-Files-and-Exceptions-More-Exercises-Resources\sample_text.txt");
            var matches = Regex.Split(file, @"[,]|[.]|[!]|[?]|[:]");
            string textToOutput = "";
            foreach (var match in matches)
            {
                textToOutput += match;
            }
            File.AppendAllText("output.txt", textToOutput);
        }
    }
}
