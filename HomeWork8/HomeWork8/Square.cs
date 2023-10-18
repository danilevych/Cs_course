using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    internal class Square : Shape
    {
        public int side;

        public override string Name => base.Name + "_Square";

        public Square(int side, string name) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 2 * (side * side);
        }
    }
}
