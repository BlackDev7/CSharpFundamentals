using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _5.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> powerOfCards = new Dictionary<string, int>()
            {
                { "1", 1}, { "2", 2}, { "3", 3}, { "4", 4}, { "5", 5},
                { "6", 6}, { "7", 7}, { "8", 8}, { "9", 9}, { "10", 10},
                { "J", 11}, { "Q", 12}, { "K", 13}, { "A", 14}
            };
            Dictionary<char, int> multiplier = new Dictionary<char, int>()
            {
                { 'S', 4 }, { 'H', 3 }, { 'D', 2 },  {'C', 1}
            };
            Dictionary<string, List<int>> holdingCards = new Dictionary<string, List<int>>();

            var line = Console.ReadLine();
            while (line != "JOKER")
            {
                string[] tokens = line.Split(':');
                string name = tokens[0];
                string[] cards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    int cardValue = 0;
                    string powerOfCard = card.Substring(0, card.Length - 1);
                    string multiplierOfCard = card.Substring(card.Length - 1);
                    cardValue = powerOfCards[powerOfCard] * multiplier[char.Parse(multiplierOfCard)];
                    if (!holdingCards.ContainsKey(name))
                    {
                        holdingCards[name] = new List<int> {};
                        holdingCards[name].Add(cardValue);
                    }
                    else
                    {
                        holdingCards[name].Add(cardValue);
                    }
                    
                }
                line = Console.ReadLine();
            }
            foreach (var kvp in holdingCards)
            {
                string name = kvp.Key;
                List<int> valueOfCards = kvp.Value.Distinct().ToList();
                
                Console.WriteLine(name + ": " + valueOfCards.Sum());
            }
        }
    }
}
