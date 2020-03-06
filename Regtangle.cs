using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Regtangle:Shape
    {
        private double length;
        private double height;

        public Regtangle(double length,double height)
        {
            this.height = height;
            this.length = length;
        }

        public double Len() { return length; }
        public double Hei() { return height; }

        public string GetInfo()
        {
            return ("The length of this regtangle is "+Len()+" and the height is "+Hei());
        }
        public string GetShapeType()
        {
            return "Regtangle";
        }
        public bool IsRight()
        {
            return (length > 0 && height > 0);
        }

        public double GetArea()
        {
            return this.IsRight() ? height * length : -1;
        }
    }
}
