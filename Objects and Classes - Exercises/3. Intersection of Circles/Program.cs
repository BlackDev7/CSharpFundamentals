using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle();
            Circle circle2 = ReadCircle();

            if (IsIntersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool IsIntersect(Circle circle1, Circle circle2)
        {
            double distanceBetweenCenters = FindDistanceBetweenCenters(circle1.Center, circle2.Center);
            if (distanceBetweenCenters <= circle1.Radius + circle2.Radius)
            {
                return true;
            }
                return false;
        }

        private static double FindDistanceBetweenCenters(Point circle1Center, Point circle2Center)
        {
            double distance = Math.Sqrt(Math.Pow(circle2Center.X - circle1Center.X, 2) + Math.Pow(circle2Center.Y - circle1Center.Y, 2));
            return distance;
        }

        private static Circle ReadCircle()
        {
            var tokens = Console.ReadLine().Split();
            var x = double.Parse(tokens[0]);
            var y = double.Parse(tokens[1]);
            var r = double.Parse(tokens[2]);
            return new Circle{Center = new Point{X = x, Y = y}, Radius = r};
        }



    }
}
