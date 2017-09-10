using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }

    class Program
    {

        static double DistanceBetweenPoints(Point point1, Point point2)
        {
            //dist((x, y), (x1, y2)) = √(x - x1)² + (y - x2)²
            double deltaX = point1.X - point2.X;
            double deltaY = point1.Y - point2.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        static void Main(string[] args)
        {
            var firstPointInput = Console.ReadLine().Split();
            var secondPointInput = Console.ReadLine().Split();

            Point firstPoint = new Point(){ X = double.Parse(firstPointInput[0]), Y = double.Parse(firstPointInput[1])};
            Point secondPoint = new Point() { X = double.Parse(secondPointInput[0]), Y = double.Parse(secondPointInput[1]) };
            Console.WriteLine(DistanceBetweenPoints(firstPoint, secondPoint));
        }
    }
}
