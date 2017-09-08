using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Personal_Exception
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException()
            : base() { }

        public NegativeNumberException(string message)
            : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var line = int.Parse(Console.ReadLine());
                while (line > -1)
                {
                    Console.WriteLine(line);
                    line = int.Parse(Console.ReadLine());
                }
                throw new NegativeNumberException("My first exception is awesome!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
