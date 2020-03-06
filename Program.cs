using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSum = 0;
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Dou you want to create the shape yourself? Press y to say yes:)");
                Shape shape;
                if (!(Console.ReadLine()=="y"|| Console.ReadLine() == "Y"))
                    shape = ShapeFactory.CreateShapeRamdomly(rd.Next(1, 5));
                else
                    shape = ShapeFactory.CreateShapeMyself();
                Console.WriteLine("第" + (i + 1).ToString() + "个形状！");
                Console.WriteLine("This is a " + shape.GetShapeType());
                Console.WriteLine(shape.GetInfo()); 
                Console.WriteLine("The area is " + shape.GetArea());
                Console.WriteLine();
                areaSum += shape.GetArea();
            }
            Console.WriteLine("The sum area is " + areaSum.ToString());
        }
    }
}

