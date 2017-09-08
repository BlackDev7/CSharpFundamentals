using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = Console.ReadLine();
            while (!(line == "Even" || line == "Odd"))
            {
                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(tokens[1]));
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, int.Parse(tokens[1]));
                }

                line = Console.ReadLine();
            }

            if(line == "Odd")
            {
                var odds = numbers.Where(index => index % 2 != 0);
                Console.WriteLine(string.Join(" ", odds));

            }
            else
            {
                var evens = numbers.Where(index => index % 2 != 1);
                Console.WriteLine(string.Join(" ", evens));
            }
        }
    }
}
