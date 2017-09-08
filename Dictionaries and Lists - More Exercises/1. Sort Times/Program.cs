using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var dates = input.OrderBy(date => date).ToList();

            Console.WriteLine(string.Join(", ", dates));
        }
    }
}
