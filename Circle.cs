using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Circle:Shape
    {
        private double radius;
        public Circle(double r)
        {
            this.radius = r;
        }
        public double R() { return radius; }
        public string GetShapeType()
        {
            return "Circle";
        }
        public string GetInfo()
        {
            return ("The radius of this circle is "+R());
        }
        public bool IsRight()
        {
            return (radius > 0);
        }

        public double GetArea()
        {
            return IsRight() ? 3.14159 * radius * radius : -1;
        }
    }
}
