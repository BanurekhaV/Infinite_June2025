using System;

namespace Day3CSharp
{
    class Employee
    {
        int EmpId;
        string EmpName;
        DateTime DOJ;
        double Salary;

        //constructor 1
         internal Employee()
        {
            EmpId = 1;
            EmpName = "Adithya";
            DOJ = Convert.ToDateTime("01/06/2025");
            Salary = 35000;
        }

        //constructor 2
        public Employee(int empid, string ename)
        {
            EmpId = empid;
            EmpName = ename;
        }
        //constructor 3
        public Employee(int EmpId, string EmpName, DateTime DOJ, double Salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.DOJ = DOJ;
            this.Salary = Salary;
        }

        //destructor
        ~ Employee()
        {
            Console.WriteLine("Bye from Employee..");
            Console.Read();
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"{EmpId}, {EmpName}, {DOJ}, and {Salary}");
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ShowEmployee();
            Employee employee2 = new Employee(100, "Akhilesh");
            employee2.ShowEmployee();
            Employee employee3 = new Employee(101, "Dinesh", Convert.ToDateTime("06/02/2025"), 35000);
            employee3.ShowEmployee();                
            Console.Read();
        }

    }
}
