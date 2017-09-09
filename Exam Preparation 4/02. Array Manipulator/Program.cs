using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = new List<int>();
            listOfInt.AddRange(Console.ReadLine().Split().Select(int.Parse));

            var line = Console.ReadLine();
            while (line != "end")
            {
                ManipulateList(line, listOfInt);
                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", listOfInt)}]");
        }

        private static void ManipulateList(string line, List<int> listOfInt)
        {
            var tokens = line.Split();
            switch (tokens[0])
            {
                case "exchange":
                    ExchangeList(tokens, listOfInt);
                    break;
                case "max":
                    GetMaxOfList(listOfInt, tokens);
                    break;
                case "min":
                    GetMinOfList(listOfInt, tokens);
                    break;
                case "first":
                    GetFirstOfList(listOfInt, tokens);
                    break;
                case "last":
                    GetLastOfList(listOfInt, tokens);
                    break;
            }
        }

        private static void GetLastOfList(List<int> listOfInt, string[] tokens)
        {
            var count = int.Parse(tokens[1]);
            var evenOrodd = tokens[2];
            var listOfOdds = new List<int>();
            var listOfEvens = new List<int>();
            foreach (var number in listOfInt)
            {
                if (number % 2 == 0)
                {
                    listOfEvens.Add(number);
                }
                else
                {
                    listOfOdds.Add(number);
                }
            }
            if (evenOrodd == "even")
            {
                if (count <= listOfInt.Count)
                {
                    listOfEvens.Reverse();
                    var lastEvens = listOfEvens.Take(count).Reverse();
                    listOfEvens.Reverse();
                    Console.WriteLine($"[{string.Join(", ", lastEvens)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }
            else
            {
                if (count <= listOfInt.Count)
                {
                    listOfOdds.Reverse();
                    var lastOdds = listOfOdds.Take(count).Reverse();
                    listOfOdds.Reverse();
                    Console.WriteLine($"[{string.Join(", ", lastOdds)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }
        }

        private static void GetFirstOfList(List<int> listOfInt, string[] tokens)
        {
            var count = int.Parse(tokens[1]);
            var evenOrodd = tokens[2];
            var listOfOdds = new List<int>();
            var listOfEvens = new List<int>();
            foreach (var number in listOfInt)
            {
                if (number % 2 == 0)
                {
                    listOfEvens.Add(number);
                }
                else
                {
                    listOfOdds.Add(number);
                }
            }
            if (evenOrodd == "even")
            {
                if (count <= listOfInt.Count)
                {
                    Console.WriteLine($"[{string.Join(", ", listOfEvens.Take(count))}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }
            else
            {
                if (count <= listOfInt.Count)
                {
                    Console.WriteLine($"[{string.Join(", ", listOfOdds.Take(count))}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }
        }

        private static void GetMinOfList(List<int> listOfInt, string[] tokens)
        {
            var evenOrOdd = tokens[1];
            var listOfOdds = new List<int>();
            var listOfEvens = new List<int>();
            var minEven = 0;
            var minOdd = 0;
            foreach (var number in listOfInt)
            {
                if (number % 2 == 0)
                {
                    listOfEvens.Add(number);
                }
                else
                {
                    listOfOdds.Add(number);
                }
            }
            if (evenOrOdd == "even")
            {
                if (listOfEvens.Count > 0)
                {
                    minEven = listOfEvens.FindLast(x => x == listOfEvens.Min());
                    Console.WriteLine(listOfInt.FindLastIndex(x => x == minEven));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                if (listOfOdds.Count > 0)
                {
                    minOdd = listOfOdds.FindLast(x => x == listOfOdds.Min());
                    Console.WriteLine(listOfInt.FindLastIndex(x => x == minOdd));
                }
                else
                {
                    Console.WriteLine("No matches");
                }

            }
        }

        private static void GetMaxOfList(List<int> listOfInt, string[] tokens)
        {
            var evenOrOdd = tokens[1];
            var listOfOdds = new List<int>();
            var listOfEvens = new List<int>();
            var maxEven = 0;
            var maxOdd = 0;
            foreach (var number in listOfInt)
            {
                if (number % 2 == 0)
                {
                    listOfEvens.Add(number);
                }
                else
                {
                    listOfOdds.Add(number);
                }
            }
            if (evenOrOdd == "even")
            {
                if (listOfEvens.Count > 0)
                {
                    maxEven = listOfEvens.FindLast(x => x == listOfEvens.Max());
                    Console.WriteLine(listOfInt.FindLastIndex(x => x == maxEven));
                }
                else
                {
                    Console.WriteLine("No matches");
                }    
            }
            else
            {
                if (listOfOdds.Count > 0)
                {
                    maxOdd = listOfOdds.FindLast(x => x == listOfOdds.Max());
                    Console.WriteLine(listOfInt.FindLastIndex(x => x == maxOdd));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
               
            }
        }

        private static void ExchangeList(string[] tokens, List<int> listOfInt)
        {
            var indexToSplit = int.Parse(tokens[1]);
            try
            {
                List<int> tempList = listOfInt.GetRange(indexToSplit + 1, listOfInt.Count - 1 - indexToSplit);
                listOfInt.RemoveRange(indexToSplit + 1, listOfInt.Count - 1 - indexToSplit);
                listOfInt.InsertRange(0, tempList);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid index");
            }
        }
    }
}
