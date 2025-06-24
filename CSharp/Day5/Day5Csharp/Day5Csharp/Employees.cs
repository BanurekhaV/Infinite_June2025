using System;


namespace Day5Csharp
{
    class Employees
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }

        //declaring indexers for the class
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return EName;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Gender;
                else if (index == 5)
                    return Department;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    Id = Convert.ToInt32(value);
                else if (index == 1)
                    EName = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
                else if (index == 4)
                    Gender = value.ToString();
                else if (index == 5)
                    Department = value.ToString();
            }
        }
    }

    class IndexersEg
    {
        public static void Main()
        {
            Employees emp = new Employees
            {
                Id = 11,
                EName = "Karthikeya",
                Job = "Analyst",
                Salary = 35000,
                Gender = "Male",
                Department = "IT"
            };
            //let us try accessing the members using indexers
            Console.WriteLine("Employee Id =" + emp[0]);
            Console.WriteLine("Employee Name = " + emp[1]);
            Console.WriteLine("Employee Salary = " + emp[3]);
            Console.WriteLine("Employee Works For = " + emp[5] + " Department");

            Console.Read();
        }
    }
}
