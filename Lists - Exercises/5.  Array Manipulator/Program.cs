using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = Console.ReadLine();
            while (!(line == "print"))
            {
                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "add")
                {
                    int index = int.Parse(tokens[1]);
                    int numberToAdd = int.Parse(tokens[2]);
                    numbers.Insert(index, numberToAdd);
                }
                else if (command == "addMany")
                {
                    int index = int.Parse(tokens[1]);
                    List<int> numbersToAdd = line.Split().Skip(2).Select(int.Parse).ToList();

                    numbers.InsertRange(index, numbersToAdd);
                }
                else if (command == "contains")
                {
                    int elementToSearch = int.Parse(tokens[1]);
                    if(numbers.Exists(x => x == elementToSearch))
                    {

                        int indexOfElement = numbers.FindIndex(x => x == elementToSearch);
                        Console.WriteLine(indexOfElement);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }

                else if (command == "remove")
                {
                    int index = int.Parse(tokens[1]);

                    numbers.RemoveAt(index);
                }

                else if (command == "shift")
                {
                    int positionsToShift = int.Parse(tokens[1]);

                    for (int i = 0; i < positionsToShift; i++)
                    {
                        numbers.Add(numbers.First());
                        numbers.RemoveAt(0);
                    }
                    
                }

                else if (command == "sumPairs")
                {
                    List<int> pairsSum = new List<int> { };
                    for (int i = 0; i < numbers.Count() ; i += 2)
                    {
                        int currentElement = numbers[i];
                        int nextElement = 0;

                        if(i < numbers.Count - 1)
                        {
                            nextElement = numbers[i + 1];
                        }
                        int elementSum = currentElement + nextElement;

                        pairsSum.Add(elementSum);
                    }

                    numbers = pairsSum;
                }

                line = Console.ReadLine();
            }
          
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");

        }
    }
}
