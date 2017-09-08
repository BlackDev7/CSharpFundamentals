using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userPlates = new Dictionary<string, string>();
            var numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens[0] == "register")
                {
                    var name = tokens[1];
                    var licencePlate = tokens[2];

                    Regex regex = new Regex(@"\b([A-Z]{2})([1-9]{4})([A-Z]{2})\b");
                    Match match = regex.Match(licencePlate);
                    if (match.Success)
                    {
                        bool isGood = true;
                        if (userPlates.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {userPlates[name]}");
                            isGood = false;
                        }
                        foreach (var user in userPlates)
                        {
                            if (user.Value.Equals(licencePlate))
                            {
                                Console.WriteLine($"ERROR: license plate {licencePlate} is busy");
                                isGood = false;
                            }
                        }
                        if (isGood)
                        {
                            userPlates[name] = licencePlate;
                            Console.WriteLine($"{name} registered {licencePlate} successfully");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licencePlate}");
                    }
                }
                else
                {
                    bool isGood = true;
                    var name = tokens[1];
                    if (!userPlates.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        isGood = false;
                    }
                    if (isGood)
                    {
                        userPlates.Remove(name);
                        Console.WriteLine($"user {name} unregistered successfully");
                    }
                }
            }
            foreach (var user in userPlates)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
