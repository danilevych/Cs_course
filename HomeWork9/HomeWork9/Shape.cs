using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;

        public virtual string Name { get { return name; } }

        public Shape(string name) { this.name = name; }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            Shape otherShape = other as Shape;
            if (otherShape != null)
            {
                return Perimeter().CompareTo(otherShape.Perimeter());
            }
            else { throw new ArgumentException("Wrong type"); }
        }

        
    }
}