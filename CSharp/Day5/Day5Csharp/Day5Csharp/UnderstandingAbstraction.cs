using System;


namespace Day5Csharp
{
    abstract class Phones
    {
       public string PhoneType = "Phones";

        abstract public void Work(); 
        public void NonAbstractMethod()
        {
            Console.WriteLine("This is Phones Nonabstract method..");
        }

        public virtual void nonAbstractVirtualMethod()
        {
            Console.WriteLine("This is virtual method of Phones, you can change it..");
        }
    }

    class Mobile : Phones
    {
        public override void Work()
        {
            PhoneType = "Mobiles";
            Console.WriteLine("I am a Mobile Phone" + " " + PhoneType);
        }

        public new void NonAbstractMethod()
        {
            Console.WriteLine("This is Mobile hidden method..");
        }

        public override void nonAbstractVirtualMethod()
        {
            Console.WriteLine("This is Virtual method overridden by the Mobile class");
        }
    }
    class UnderstandingAbstraction
    {
        public static void Main()
        {
            Phones ph = new Mobile();  //
            // ph.Work();
           // ph.NonAbstractMethod();
            ph.nonAbstractVirtualMethod();
           
            Mobile mobile = new Mobile();
            // mobile.Work();
            // mobile.NonAbstractMethod();
            mobile.nonAbstractVirtualMethod();
            Console.Read();
        }
    }
}
