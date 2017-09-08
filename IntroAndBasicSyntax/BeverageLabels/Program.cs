using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContentPer100 = double.Parse(Console.ReadLine());
            double sugarContentPer100 = double.Parse(Console.ReadLine());

            ConvertingAndPrintingBeverageLabel(name, volume, energyContentPer100, sugarContentPer100);
        }

        static void ConvertingAndPrintingBeverageLabel(string name, double volume, double energy, double sugar)
        {
            double totalEnergyContent = energy * (volume / 100);
            double totalSugarContent = sugar * (volume / 100);
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, totalEnergyContent, totalSugarContent);
        }
    }
}
