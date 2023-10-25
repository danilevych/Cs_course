using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
        public struct Point
        {
            public double X, Y;

            public Point(double x, double y)
            {
                this.X = x; this.Y = y;
            }

            public double Distance(Point other)
            {
            double deltaX = other.X - this.X;
            double deltaY = other.Y - this.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
            }

            public override string ToString()
            {
                return string.Format("Point({0}, {1})", X, Y);
            }
    }
}
