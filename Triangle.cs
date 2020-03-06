using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Triangle:Shape
    {
        private double edge1;
        private double edge2;
        private double edge3;

        public Triangle(double e1,double e2,double e3)
        {
            edge1 = e1;
            edge2 = e2;
            edge3 = e3;
        }
        
        public double E1() { return edge1; }
        public double E2() { return edge2; }
        public double E3() { return edge3; }

        public string GetInfo()
        {
            return ("The length of each edge is "+E1()+" and "+E2()+" and "+E3());
        }
        public string GetShapeType()
        {
            return "Triangle";
        }
        public double GetArea()
        {
            if (IsRight())
            {
                double p = (edge1 + edge2 + edge3) / 2;
                double area = Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
                return area;
            }
            else
                return -1;
        }

        public bool IsRight()
        {
            if (edge1 > 0 && edge2 > 0 && edge3 > 0)
                if (edge1 + edge2 > edge3 && edge3 + edge2 > edge1 && edge1 + edge3 > edge2)
                    return true;
            return false;
        }
    }
}
