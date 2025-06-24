using System;


namespace Day5Csharp
{
    interface IName
    {
        string Name { get; set; }  //decl of property        
    }

    class Employee : IName
    {
        public string Name { get; set; }
    }

    class Company : IName
    {
        // private string companyname { get; set; }  //class property
        private string companyname;
       public int _age { get; set; } = 21;

        public string Name
        {
            get { return companyname; }
            set { companyname = value; }
        }
    }
    class Interfacewith_Properties
    {
        static void Main()
        {
            IName e = new Employee();
            e.Name = "Karthika";

            IName c = new Company();
            c.Name = "Infinite Ltd.,";

            Console.WriteLine("This is {0} from {1}", e.Name, c.Name);
            Console.WriteLine("***************"); 
            Company company = new Company();
            company.Name = "New Infinite";
            company._age = 25;

            Console.WriteLine(company.Name + " is " + company._age + " Years Old");
            Console.Read();
        }
    }
}
