using System;

namespace Day4CSharp
{
    class Shape
    {
        protected float R, L, B;

        public virtual float Area()
        {
            return 3.14f * R * R;
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length: ");
            L = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth:");
            B = Convert.ToSingle(Console.ReadLine());
        }

       public override float Area()
        {
            GetLB();
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius:");
            R = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 11.45f;
        }
    }

    class OverridingEg
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Area of Rectangle is {0}", rectangle.Area());
            Console.WriteLine("Rectangle Circumference is {0}", rectangle.Circumference());
            Circle circle = new Circle();
            Console.WriteLine("Area and Circumference of Circle {0} , {1}", circle.Area(), circle.Circumference());

            Console.WriteLine("-----------------");
            circle.GetRadius();
            Console.WriteLine("Area and Circumference of Circle {0} , {1}", circle.Area(), circle.Cicumference());

            Console.Read();
        }
    }
}
