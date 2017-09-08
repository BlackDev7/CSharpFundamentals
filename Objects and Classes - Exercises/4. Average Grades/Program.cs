using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class Student
    {
        //name, list of grades and average grade 
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();

    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var studentName = tokens[0];
                List<double> grades = tokens.Skip(1).Select(double.Parse).ToList();
                students.Add(new Student {Grades = grades, Name = studentName});
            }
            List<Student> filteredStudents = students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).Where(x => x.AverageGrade >= 5.00).ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade);
            }

        }
    }
}
