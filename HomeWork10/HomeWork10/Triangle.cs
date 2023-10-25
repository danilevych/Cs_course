using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;

        public Triangle(Point a, Point b, Point c)
        {
            this.vertex1 = a; 
            this.vertex2 = b; 
            this.vertex3 = c;
        }

        public double Perimeter()
        {
            double side1 = Distance(vertex1, vertex2);
            double side2 = Distance(vertex2, vertex3);
            double side3 = Distance(vertex3, vertex1);
            return side1 + side2 + side3;
        }

        public double Square()
        {
            double side1 = Distance(vertex1, vertex2);
            double side2 = Distance(vertex2, vertex3);
            double side3 = Distance(vertex3, vertex1);

            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public void Print(Point a, Point b, Point c)
        {
            Console.WriteLine($"Point vertex1: ({vertex1.X}, {vertex1.Y})");
            Console.WriteLine($"Point vertex2: ({vertex2.X}, {vertex2.Y})");
            Console.WriteLine($"Point vertex3: ({vertex3.X}, {vertex3.Y})");
        }

        public double Distance(Point point1, Point point2)
        {
            double deltaX = point2.X - point1.X;
            double deltaY = point2.Y - point1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
