using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class ShapeFactory
    {
        public static Shape CreateShapeRamdomly(int type)
        {
            Shape shape = null;
            Random rd = new Random();
            switch(type)
            {
                case 1:
                    shape = new Regtangle(rd.Next(1, 10), rd.Next(1, 10));
                    break;
                case 2:
                    shape = new Triangle(rd.Next(1, 10), rd.Next(1, 10), rd.Next(1, 10));
                    while (!shape.IsRight())
                        shape = new Triangle(rd.Next(1, 10), rd.Next(1, 10), rd.Next(1, 10));
                    break;
                case 3:
                    shape = new Square(rd.Next(1, 10));
                    break;
                case 4:
                    shape = new Circle(rd.Next(1, 10));
                    break;
                default:
                    Console.WriteLine("not my shape!");
                    break;
            }
            return shape;
        }

        public static Shape CreateShapeMyself()
        {
            Shape shape = null;
            Console.WriteLine("Which shape do you want? A.Regtangle B.Triangle C.Square D.Circle");
            string type = Console.ReadLine();
            try
            {
                switch (type)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("Enter the length:");
                        double l = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height:");
                        double h = double.Parse(Console.ReadLine());
                        shape = new Regtangle(l, h);
                        if (!shape.IsRight())
                            shape = new Regtangle(1, 1);
                        break;
                    case "B":
                    case "b":
                        Console.WriteLine("Enter 3 edges:");
                        double e1 = double.Parse(Console.ReadLine());
                        double e2 = double.Parse(Console.ReadLine());
                        double e3 = double.Parse(Console.ReadLine());
                        shape = new Triangle(e1, e2, e3);
                        if (!shape.IsRight())
                            shape = new Triangle(1, 1, 1);
                        break;
                    case "C":
                    case "c":
                        Console.WriteLine("Enter the side:");
                        double side = double.Parse(Console.ReadLine());
                        shape = new Square(side);
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Enter the radius:");
                        double r = double.Parse(Console.ReadLine());
                        shape = new Circle(r);
                        break;
                    default:
                        Console.WriteLine("not my shape!");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return shape;
        }
    }
}
