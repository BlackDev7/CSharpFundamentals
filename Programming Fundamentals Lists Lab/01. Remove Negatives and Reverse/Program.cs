﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listWithoutNegatives = new List<int> { };

            foreach (var num in numbers)
            {
                if(num > 0)
                {
                    listWithoutNegatives.Add(num);
                }
            }

            if(listWithoutNegatives.Any())
            {
                listWithoutNegatives.Reverse();
                Console.WriteLine(string.Join(", ", listWithoutNegatives));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
