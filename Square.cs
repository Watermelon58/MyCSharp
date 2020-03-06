using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Square:Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double Side() { return side; }
        public string GetShapeType()
        {
            return "Square";
        }

        public string GetInfo()
        {
            return ("The side of this Square is "+Side());
        }

        public bool IsRight()
        {
            return (side > 0);
        }

        public double GetArea()
        {
            return this.IsRight() ? side*side : -1;
        }
    }
}
