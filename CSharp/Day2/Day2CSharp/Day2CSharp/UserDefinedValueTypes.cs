using System;


namespace Day2CSharp
{
    struct Student
    {
        public float mathsmarks;
        public float sciencemarks;

        public void Show()
        {
            Console.WriteLine(mathsmarks + " " + sciencemarks);
        }
    }
    class UserDefinedValueTypes
    {
        public static void Main()
        {
            Student s1 = new Student();
            s1.mathsmarks = 91.5f;
            s1.sciencemarks = 80f;
            Console.WriteLine(s1.mathsmarks + s1.sciencemarks);
            s1.Show();
            Student s2 = s1; // assigning s1 to s2
            Console.WriteLine(s2.mathsmarks + s2.sciencemarks);
            Console.WriteLine("----------After reassigning values ----------");

            s1.mathsmarks = 95;
            Console.WriteLine(s1.mathsmarks + s1.sciencemarks);
            Console.WriteLine("--------Function Calls-------");
            s1.Show();
            s2.Show();
            Console.WriteLine(s2.mathsmarks + s2.sciencemarks);
            Console.WriteLine("--------Enumerations------------");
            Enumerations.EnumOps();
            Console.WriteLine("-------Trying Enums from other classes------");
            checkingEnumfromOutside();
            Console.Read();
        }

        public static void checkingEnumfromOutside()
        {
            foreach (int c in Enum.GetValues(typeof(cities)))
            {
                if (c == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Garden City");
                else if (c == 2)
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Temple City");
                else if (c == 5)
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Steel City");
            }
            
            foreach(int i in Enum.GetValues(typeof(Enumerations.Days)))
            {
                Console.WriteLine(i);
            }
            
        }
    }

    enum cities {Agra=3, Bangalore=1, Chennai=2, Delhi=4, Hyderabad=6, Vizag=5}
    class Enumerations
    {
        public enum Days {Mon=10, Tue, Wed, Thur, Fri=20, Sat, Sun} 
        public static void EnumOps()
        {
            //understanding enumerations
            Console.WriteLine("Hi Enum");
            foreach (int c in Enum.GetValues(typeof(cities)))
            {
                if (c == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Garden City");
                else if (c == 2)
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Temple City");
                else if (c == 5)
                    Console.WriteLine(Enum.GetName(typeof(cities), c) + " " + "is a Steel City");
            } 
                Console.WriteLine("------------");

                foreach(var x in Enum.GetNames(typeof(cities)))
                {
                    Console.WriteLine(x);
                }
            Console.WriteLine("---Accessing Constants------");
            int wkstart = (int)Days.Mon;
            int wkend = (int)Days.Fri;

            Console.WriteLine("Mondays are Weekstarts :{0}", wkstart);
            Console.WriteLine("Fridays are :{0}", wkend);
        }
    }
}
