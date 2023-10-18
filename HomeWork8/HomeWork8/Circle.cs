using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Circle : Shape
    {
        public int radius;

        public override string Name => base.Name + "_Circle";

        public Circle(int radius, string name) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 2 * Math.PI * radius;
        }
        public override double Perimeter()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
