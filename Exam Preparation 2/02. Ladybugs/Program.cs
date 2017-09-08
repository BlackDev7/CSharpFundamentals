using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = long.Parse(Console.ReadLine());
            var initialindexes = Console.ReadLine().Split().Select(long.Parse).ToList();
            Dictionary<long, bool> ladybugs = new Dictionary<long, bool>();
            MoveLadyBugs(fieldSize, initialindexes, ladybugs);
            PrintLadyBugs(ladybugs);
        }

        private static void PrintLadyBugs(Dictionary<long, bool> ladybugs)
        {
            List<long> bugsOnField = new List<long>();
            foreach (var bug in ladybugs)
            {
                if (bug.Value)
                {
                    bugsOnField.Add(1);
                }
                else
                {
                    bugsOnField.Add(0);
                }
            }
            Console.WriteLine(string.Join(" ", bugsOnField));
        }

        private static void MoveLadyBugs(long fieldSize, List<long> initialindexes, Dictionary<long, bool> ladybugs)
        {
            for (long i = 0; i < fieldSize; i++)
            {
                if (initialindexes.Contains(i))
                {
                    ladybugs[i] = true;
                }
                else
                {
                    ladybugs[i] = false;
                }
            }
            var commands = Console.ReadLine().Split();
            while (!commands.Contains("end"))
            {
                var index = long.Parse(commands[0]);
                var command = commands[1];
                var flyRange = long.Parse(commands[2]);

                if (ladybugs.ContainsKey(index))
                {
                    if (ladybugs[index] == true)
                    {
                        if (command == "left")
                        {
                            if (index - flyRange < 0)
                            {
                                ladybugs[index] = false;
                            }
                            else
                            {
                                var indexToBePlaced = index;
                                while (ladybugs[indexToBePlaced])
                                {
                                    indexToBePlaced -= flyRange;
                                    if (indexToBePlaced < 0)
                                    {
                                        break;
                                    }
                                }
                                if (indexToBePlaced < 0)
                                {
                                    ladybugs[index] = false;
                                }
                                else
                                {
                                    ladybugs[index] = false;
                                    ladybugs[indexToBePlaced] = true;
                                }
                            }
                        }
                        if (command == "right")
                        {
                            if (index + flyRange > fieldSize - 1)
                            {
                                ladybugs[index] = false;
                            }
                            else
                            {
                                var indexToBePlaced = index;
                                while (ladybugs[indexToBePlaced])
                                {
                                    indexToBePlaced += flyRange;
                                    if (indexToBePlaced > fieldSize - 1)
                                    {
                                        break;
                                    }
                                }
                                if (indexToBePlaced > fieldSize - 1)
                                {
                                    ladybugs[index] = false;
                                }
                                else
                                {
                                    ladybugs[index] = false;
                                    ladybugs[indexToBePlaced] = true;
                                }
                            }
                        }
                    }
                }
                commands = Console.ReadLine().Split();
            }
        }
    }
}