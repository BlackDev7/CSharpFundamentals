using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Order_by_Age
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            ReadPersons(persons);
            PrintPersons(persons);
        }

        private static void PrintPersons(List<Person> persons)
        {
            var orderedByAge = persons.OrderBy(x => x.Age).ToList();
            foreach (var person in orderedByAge)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }

        private static void ReadPersons(List<Person> persons)
        {
            var line = Console.ReadLine();
            while (line != "End")
            {
                var tokens = line.Split();
                var name = tokens[0];
                var id = tokens[1];
                int age = int.Parse(tokens[2]);
                persons.Add(new Person { Name = name, ID = id, Age = age });
                line = Console.ReadLine();
            }
        }
    }
}
