using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameEmails = new Dictionary<string, string>();

            string line = Console.ReadLine();

            while (line != "stop")
            {
                string name = line;
                string email = Console.ReadLine();

                nameEmails[name] = email;

                line = Console.ReadLine();
            }

            var fixedEmails = nameEmails.Where(kvp => !(kvp.Value.EndsWith("uk") || kvp.Value.EndsWith("us"))).ToDictionary(a => a.Key, a => a.Value);

            foreach (var person in fixedEmails)
            {
                Console.WriteLine(person.Key + " -> " + person.Value);
            }
            
        }
    }
}
