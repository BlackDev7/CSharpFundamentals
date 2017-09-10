using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = new List<int>();
            listOfIntegers.AddRange(Console.ReadLine().Split().Select(int.Parse));
            var sumOfRemovedElements = 0;
            while (listOfIntegers.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                bool alreadyDone = false;
                var valueAtIndex = 0;
                if (index < 0)
                {
                    valueAtIndex = listOfIntegers[0];
                    listOfIntegers[0] = listOfIntegers.Last();
                    index = 0;
                    alreadyDone = true;
                }
                if (index > listOfIntegers.Count - 1)
                {
                    valueAtIndex = listOfIntegers[listOfIntegers.Count - 1];
                    listOfIntegers[listOfIntegers.Count - 1] = listOfIntegers.First();
                    index = listOfIntegers.Count - 1;
                    alreadyDone = true;
                }

                if (!(index > listOfIntegers.Count - 1) && !alreadyDone)
                {
                    valueAtIndex = listOfIntegers[index];
                    listOfIntegers.RemoveAt(index);
                } 
                sumOfRemovedElements += valueAtIndex;
                for (int i = 0; i < listOfIntegers.Count; i++)
                {
                    if (valueAtIndex < listOfIntegers[i])
                    {
                        listOfIntegers[i] -= valueAtIndex;
                    }
                    else
                    {
                        listOfIntegers[i] += valueAtIndex;
                    }
                }
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
