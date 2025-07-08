using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Csharp
{
    public class Shape
    {
        public const float PI = 3.14f;
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Rectangle: Shape
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(double l, double b)
        {
            Length = l;
            Breadth = b;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }
        
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

    }
    class PatternMatching2
    {
        //prior to c# 7.0 . Testing each type in a series and then casting it accordingly
        //public static void DisplayArea(Shape shape)
        //{
        //    if(shape is Circle)
        //    {
        //        Circle c = (Circle)shape;
        //        Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
        //    }
        //    else if (shape is Rectangle)
        //    {
        //       Rectangle r = (Rectangle)shape;
        //        Console.WriteLine("Area of Rectangle is : " + r.Length * r.Breadth);
        //    }
        //    else if (shape is Triangle)
        //    {
        //        Triangle t = (Triangle)shape;
        //        Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
        //    }
        //    else
        //    {
        //        throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
        //    }
        //}

        //with C# 7.0
        //public static void DisplayArea(Shape shape)
        //{
        //    if (shape is Circle c)
        //    {
        //       Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
        //    }
        //    else if (shape is Rectangle r)
        //    {
        //       Console.WriteLine("Area of Rectangle is : " + r.Length * r.Breadth);
        //    }
        //    else if (shape is Triangle t)
        //    {
        //       Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
        //    }
        //    else
        //    {
        //        throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
        //    }
        //}

        //with switch and when

        public static void DisplayArea(Shape shape)
        { 
           switch(shape)
            {
                case Rectangle r when r.Length==r.Breadth:
                    Console.WriteLine("Area of Square is : " + r.Length * r.Breadth);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Breadth);
                    break;
                case Circle c:
                    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
                    break;               
                case Triangle t:
                    Console.WriteLine("Area of Triangle is : " + 0.5 * t.Base * t.Height);
                    break;                
                case null:
                    throw new ArgumentNullException(nameof(shape));
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }
        static void Main()
        {
            Rectangle square = new Rectangle(5, 5);
            DisplayArea(square);
            Rectangle rectangle = new Rectangle(6, 7);
            DisplayArea(rectangle);
            Circle circle = new Circle(4);
            DisplayArea(circle);
            Triangle triangle = new Triangle(6, 5);
            DisplayArea(triangle);
            Console.Read();
        }
    }
}
