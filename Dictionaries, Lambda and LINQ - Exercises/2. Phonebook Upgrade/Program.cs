using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string> { };
            List<string> tokens = Console.ReadLine().Split().ToList();

            while (tokens.First() != "END")
            {
                string command = tokens.First();

                if (command == "A")
                {
                    string name = tokens.Skip(1).First();
                    string phoneNumber = tokens.Last();

                    if (!(phoneBook.ContainsKey(name)))
                    {
                        phoneBook.Add(name, phoneNumber);
                    }
                    else
                    {
                        phoneBook[name] = phoneNumber;
                    }
                }
                else if (command == "S")
                {
                    string name = tokens.Skip(1).First();
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                else
                {
                    foreach (var cont in phoneBook)
                    {
                        Console.WriteLine(cont.Key + " -> " + cont.Value);
                    }
                }
                tokens = Console.ReadLine().Split().ToList();
            }

        }
    }
}
