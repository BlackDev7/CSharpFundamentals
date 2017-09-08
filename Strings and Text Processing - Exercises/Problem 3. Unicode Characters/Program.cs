using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            Console.WriteLine(String.Join("", line.Select(c => (int)c)
                .Select(c => $@"\u{c:x4}")));
        }
    }
}
