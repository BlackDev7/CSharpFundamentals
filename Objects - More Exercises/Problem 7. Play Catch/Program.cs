using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToList();
            int expectionsEncounteres = 0;
            while (expectionsEncounteres < 3)
            {
                var tokens = Console.ReadLine().Split();
                var command = tokens[0];
                try
                {
                    switch (command)
                    {
                        case "Replace":
                            ReplaceElements(tokens, nums);
                            break;
                        case "Show":
                            ShowElement(tokens, nums);
                            break;
                        case "Print":
                            PrintElements(tokens, nums);
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    expectionsEncounteres++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    expectionsEncounteres++;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The index does not exist!");
                    expectionsEncounteres++;
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
        private static void PrintElements(string[] tokens, List<string> nums)
        {
            int startIndex = int.Parse(tokens[1]);
            int endIndex = int.Parse(tokens[2]);
            Console.WriteLine(string.Join(", ",nums.GetRange(startIndex, endIndex - startIndex + 1)));
        }

        private static void ShowElement(string[] tokens, List<string> nums)
        {
            var index = int.Parse(tokens[1]);
            Console.WriteLine(nums[index]);
        }

        private static void ReplaceElements(string[] tokens, List<string> nums)
        {
                var index = int.Parse(tokens[1]);
                var element = tokens[2];
                nums[index] = element;
        }
    }
}
