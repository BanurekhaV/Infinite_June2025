using System;


namespace Day4CSharp
{
    class Employee 
    {
        private string ecode = "N.A.";
        private string name = "Unknown";
       public int age { get; set; }  //automatic implementation of properties

        //decl properties
        public string Ecode
        {
            get { return ecode; }
           // set { ecode = value; }
        }

        public string EmpName
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return "Employee Code = " + ecode + " " + "Employee Name = " + name + " " +
                "Employee Age = " + age;           
        }
    }

    class Properties
    {
        static void Main()
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.Ecode + " " +  employee.EmpName);
            employee.EmpName = "Jahnavi";
            Console.WriteLine(employee.Ecode + " " +  employee.EmpName);

            Console.WriteLine("------------------------");
            employee.age += 5;
            Console.WriteLine("Employee Details : {0}", employee.ToString());
            Console.Read();
        }
    }

    
}
