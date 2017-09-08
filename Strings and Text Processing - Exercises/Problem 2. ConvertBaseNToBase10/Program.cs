using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Problem_2.ConvertBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();
            var baseN = int.Parse(tokens[0]);
            var baseNNumber = int.Parse(tokens[1]);

            Console.WriteLine(ConvertToBase10(baseNNumber, baseN));
        }

        private static double ConvertToBase10(int baseNNumber, int baseN)
        {
            List<double> remainders = new List<double>();
            List<char> baseNReversed = baseNNumber.ToString().Reverse().ToList();

            for (int i = 0; i < baseNReversed.Count; i++)
            {
                remainders.Add(int.Parse(baseNReversed[i].ToString()) * Math.Pow(baseN, i));
            }
            return remainders.Sum();
        }
    }
}
