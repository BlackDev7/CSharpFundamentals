using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Vehicle_Catalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //{typeOfVehicle} {model} {color} {horsepower}
            List<Vehicle> vehicles = new List<Vehicle>();
            ReadVehicle(vehicles);
            ReadModels(vehicles);
        }

        private static void ReadModels(List<Vehicle> vehicles)
        {
            var line = Console.ReadLine();
            while (line != "Close the Catalogue")
            {
                var model = line;
                foreach (var vehicle in vehicles.Where(x => x.Model == model))
                {
                    Console.WriteLine($"Type: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(vehicle.Type)}\r\nModel: {vehicle.Model}\r\nColor: {vehicle.Color}\r\nHorsepower: {vehicle.Horsepower}");
                }
                line = Console.ReadLine();
            }

            if (vehicles.Any(x => x.Type == "car"))
            {
                var averageCasrHP = vehicles.Where(x => x.Type == "car").Average(vehicle => vehicle.Horsepower);
                Console.WriteLine($"Cars have average horsepower of: {averageCasrHP:F2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            if (vehicles.Any(x => x.Type == "truck"))
            {
                var averageTrucksHP = vehicles.Where(x => x.Type == "truck").Average(vehicle => vehicle.Horsepower);
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHP:F2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
        }
        private static void ReadVehicle(List<Vehicle> vehicles)
        {
            var line = Console.ReadLine();
            while (line != "End")
            {
                var tokens = line.Split();
                var type = tokens[0];
                var model = tokens[1];
                var color = tokens[2];
                int horsepower = int.Parse(tokens[3]);
                vehicles.Add(new Vehicle {Type = type.ToLower(), Model = model, Color = color, Horsepower = horsepower});
                line = Console.ReadLine();
            }
        }
    }
}
