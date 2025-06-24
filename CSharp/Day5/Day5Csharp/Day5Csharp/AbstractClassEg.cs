using System;

namespace Day5Csharp
{
    abstract class Shapes
    {
        public string prop1 { get; set; }

        //abstract property
        public abstract float perimeter { get; set; }
        //decl an abstract method
        public abstract int Area();

        public void DrawShape()  // non abstract method 
        {
            Console.WriteLine("Drawing a Shape...");
        }
        public virtual void ShapeType()
        {
            Console.WriteLine("This is Base type Shapes..");
        }

        public Shapes(string s)
        {
            prop1 = s;
            Console.WriteLine("Shapes getting constructed...");
        }
    }

    class Square : Shapes
    {
        public override float perimeter { get; set; }
        int side = 0;

        //constructor
        public Square(int n, string str): base(str)
        {
            side = n;
        }

        //abstract with override 
        public override int Area()
        {
            return side * side;
        }

        public new void DrawShape()
        {
            Console.WriteLine("Drawing a Square Shape ..");
        }

        //virtual with override
        public override void ShapeType()
        {
            base.ShapeType();
            Console.WriteLine("This is Subtype Square Shape..");
        }
    }
    class AbstractClassEg
    {
        static void Main()
        {
            Shapes shape = new Square(6, "Base");
            Console.WriteLine("Area of Square = " +  shape.Area());
            shape.DrawShape();
            shape.ShapeType();
            Console.WriteLine("-----With Sub Type Object-------");
            Square s = new Square(10, "Base Shape");
            Console.WriteLine("Area of Square using Square Object " + s.Area()); 
            s.DrawShape();
            Console.Read();
        }
    }
}
