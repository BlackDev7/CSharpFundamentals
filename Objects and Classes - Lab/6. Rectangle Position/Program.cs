using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    class Rectangle
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = ReadRectangle(Console.ReadLine());
            Rectangle rect2 = ReadRectangle(Console.ReadLine());
            if (IsInside(rect1, rect2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }

        private static bool IsInside(Rectangle rect1, Rectangle rect2)
        {
            if (rect1.Left >= rect2.Left && rect1.Right <= rect2.Right && rect1.Top <= rect2.Top &&
                rect1.Bottom <= rect2.Bottom)
            {
                return true;
            }
            return false;
        }


        private static Rectangle ReadRectangle(string line)
        {
            var tokens = line.Split().Select(double.Parse).ToArray();
            var left = tokens[0];
            var top = tokens[1];
            var width = tokens[2];
            var height = tokens[3];

            return new Rectangle() {Left = left, Top = top, Width = width, Height = height, Right = left + width, Bottom = top + height };
        }
    }
}
