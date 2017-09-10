using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void SwapWords(string[] word, int position1, int position2)
        {
            string temp = word[position1]; 
            word[position1] = word[position2];
            word[position2] = temp; 
        }

        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length - 1);
                int secondRandomIndex = random.Next(0, words.Length - 1);
                SwapWords(words, randomIndex, secondRandomIndex);
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
