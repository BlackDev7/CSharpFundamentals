using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            int currentHealth = initialHealth;
            List<string> virusList = new List<string>();
            var virusName = Console.ReadLine();
            while (virusName != "end")
            {
                bool isVirusEncoutered = false;
                var virusStrength = 0;
                if (!virusList.Contains(virusName))
                {
                    virusList.Add(virusName);
                    isVirusEncoutered = true;

                }
                foreach (var ch in virusName)
                {
                    virusStrength += System.Convert.ToInt32(ch);
                }
                virusStrength /= 3;
                var virusDefeatTime = 0;
                if (isVirusEncoutered)
                {
                    virusDefeatTime = virusStrength * virusName.Length;
                }
                else
                {
                    virusDefeatTime = virusStrength * virusName.Length / 3;
                }

                currentHealth -= virusDefeatTime;

                var minutesToDefeat = virusDefeatTime / 60;
                var secondsToDefeat = virusDefeatTime % 60;
                string minutesSecondsToDefeat = $"{minutesToDefeat}m {secondsToDefeat}s";

                    
                Console.WriteLine($"Virus {virusName}: {virusStrength} => {virusDefeatTime} seconds");
                if (currentHealth <= 0)
                {
                    Console.WriteLine($"Immune System Defeated.");
                    break;
                }
                Console.WriteLine($"{virusName} defeated in {minutesSecondsToDefeat}.");
                Console.WriteLine($"Remaining health: {currentHealth}");
                currentHealth += currentHealth * 20 / 100;
                if (currentHealth > initialHealth) currentHealth = initialHealth;

                
                virusName = Console.ReadLine();
            }
            if(currentHealth > 0) Console.WriteLine($"Final Health: {currentHealth}"); 
        }
    }
}
