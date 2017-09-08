using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string charName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            PrintCharStats(charName, currentHealth, maxHealth, currentEnergy, maxEnergy);

        }

        static void PrintCharStats(string name, int currHealth, int maxHealth, int currEnergy, int maxEnergy)
        {

            string currentHealthBar = new string('|', currHealth);
            string missingHealth = new string('.', maxHealth - currHealth);
            string currentEnergyBar = new string('|', currEnergy);
            string missingEnergy = new string('.', maxEnergy - currEnergy);
            Console.WriteLine("Name: {0}\nHealth: |{1}{2}|\nEnergy: |{3}{4}|", name, currentHealthBar, missingHealth, currentEnergyBar, missingEnergy);

        }
    }
}
