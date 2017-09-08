using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int kNumber = nums.Count() / 4;

            List<int> leftNumbersReversed = nums.Take(kNumber).Reverse().ToList();
            List<int> rightNumbersReversed = nums.Skip(3 * kNumber).Take(kNumber).Reverse().ToList();
            List<int> leftRightNumbers = leftNumbersReversed.Concat(rightNumbersReversed).ToList();

            List<int> middleNumbers = nums.Skip(kNumber).Take(2 * kNumber).ToList();

            List<int> sum = leftRightNumbers.Select((x, index) => x + middleNumbers[index]).ToList();

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
