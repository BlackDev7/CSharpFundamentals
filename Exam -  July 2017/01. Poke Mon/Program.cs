using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var nVariable = int.Parse(Console.ReadLine());
            var mVariable = int.Parse(Console.ReadLine());
            var yVariable = int.Parse(Console.ReadLine());
            var nSubstracted = nVariable;
            var pokedCount = 0;

            while (nSubstracted >= mVariable)
            {
                nSubstracted -= mVariable;
                if (nSubstracted == nVariable / 2 && yVariable > 0)
                {
                    nSubstracted /= yVariable;
                }
                pokedCount++;
            }
            Console.WriteLine(nSubstracted);
            Console.WriteLine(pokedCount);
        }
    }
}