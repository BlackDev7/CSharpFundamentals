using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> phoneBook = new Dictionary<string, string> { };
            List<string> tokens = Console.ReadLine().Split().ToList();

            while (tokens.First() != "END")
            {
                string command = tokens.First();
                string name = tokens.Skip(1).First();

                if (command == "A")
                {
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
                else
                {
                    if(phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                tokens = Console.ReadLine().Split().ToList();
            }

        }


    }
}

