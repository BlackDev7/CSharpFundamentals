using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    public static class ShiftList
    {
        public static List<T> ShiftLeft<T>(this List<T> list, int shiftBy)
        {
            if (list.Count <= shiftBy)
            {
                return list;
            }

            var result = list.GetRange(shiftBy, list.Count - shiftBy);
            result.AddRange(list.GetRange(0, shiftBy));
            return result;
        }

        public static List<T> ShiftRight<T>(this List<T> list, int shiftBy)
        {
            if (list.Count <= shiftBy)
            {
                return list;
            }

            var result = list.GetRange(list.Count - shiftBy, shiftBy);
            result.AddRange(list.GetRange(0, list.Count - shiftBy));
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringSeries = new List<string>();
            var line = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            stringSeries.AddRange(line);

            var command = Console.ReadLine();
            while (command != "end")
            {
                var tokens = command.Split();

                try
                {
                    switch (tokens[0])
                    {
                        case "reverse":
                        {
                            var startIndex = int.Parse(tokens[2]);
                            var reverseCount = int.Parse(tokens[4]);
                            var tempList = stringSeries.GetRange(0, startIndex);
                            if (startIndex == 0)
                            {
                                tempList = stringSeries.GetRange(0, 1);
                            }
                            var revertedStrings = stringSeries.GetRange(startIndex, reverseCount);
                            revertedStrings.Reverse();
                            tempList.AddRange(revertedStrings);
                            tempList.AddRange(stringSeries.Skip(tempList.Count).Take(stringSeries.Count - tempList.Count));
                            stringSeries.Clear();
                            stringSeries.AddRange(tempList);
                            break;
                        }
                        case "sort":
                        {
                            var startIndex = int.Parse(tokens[2]);
                            var sortCount = int.Parse(tokens[4]);
                            var tempList = stringSeries.GetRange(0, startIndex);
                            if (startIndex == 0)
                            {
                                tempList = stringSeries.GetRange(0, 1);
                            }
                            var sortedString = stringSeries.GetRange(startIndex, sortCount);
                            sortedString.Sort();
                            tempList.AddRange(sortedString);
                            tempList.AddRange(stringSeries.Skip(tempList.Count).Take(stringSeries.Count - tempList.Count));
                            stringSeries.Clear();
                            stringSeries.AddRange(tempList);
                            break;
                        }
                        case "rollLeft":
                        {
                            var shiftCount = int.Parse(tokens[1]);
                            stringSeries = stringSeries.ShiftLeft(shiftCount).ToList();
                            break;
                        }
                        case "rollRight":
                        {
                            var shiftCount = int.Parse(tokens[1]);
                            stringSeries = stringSeries.ShiftRight(shiftCount);
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", stringSeries)}]" );
        }
    }
}
