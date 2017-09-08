using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] separators = { ',', ',', ':', ';', '(', ')', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            words = words.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();



            Console.WriteLine(string.Join(", ", words));
        }
    }
}
