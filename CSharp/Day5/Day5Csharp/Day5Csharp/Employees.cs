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

        //declaring indexers for the class with integer subscript
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

        //declaring indexers for the class with string subscript
        //overloading an indexer with the property names
        public object this[string index]
        {
            get
            {
                if (index.ToLower() == "id")
                    return Id;
                else if (index.ToLower() =="ename")
                    return EName;
                else if (index.ToLower() == "job")
                    return Job;
                else if (index.ToLower() == "salary")
                    return Salary;
                else if (index.ToLower() == "gender")
                    return Gender;
               else if (index.ToLower() == "department")
                    return Department;
                else
                    return null;
            }
            set
            {
                if (index =="Id")
                    Id = Convert.ToInt32(value);
                else if (index == "EName")
                    EName = value.ToString();
                else if (index == "Job")
                    Job = value.ToString();
                else if (index.ToLower() == "salary")
                    Salary = Convert.ToDouble(value);
                else if (index == "Gender")
                    Gender = value.ToString();
                else if (index == "Department")
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

            emp[1] = "Jayavardhan";
            emp[3] = 36000;

            Console.WriteLine("=========After modifications========");
            Console.WriteLine("Employee Id =" + emp[0]);
            Console.WriteLine("Employee Name = " + emp[1]);
            Console.WriteLine("Employee Salary = " + emp[3]);
            Console.WriteLine("Employee Works For = " + emp[5] + " Department");

            Console.WriteLine("=======Accessing indexer with propertyname overload =====");

            Console.WriteLine("Employee Id =" + emp["Id"]);
            Console.WriteLine("Employee Name = " + emp["EName"]);
            Console.WriteLine("Employee Salary = " + emp["Salary"]);
            Console.WriteLine("Employee Works For = " + emp["Department"] + " Department");

            emp["EName"] = "Nithin Kumar";
            emp["salary"] = 36500;

            Console.WriteLine("=========After modifications========");
            Console.WriteLine("Employee Id =" + emp["id"]);
            Console.WriteLine("Employee Name = " + emp["Ename"]);
            Console.WriteLine("Employee Salary = " + emp["salary"]);
            Console.WriteLine("Employee Works For = " + emp["dePartment"] + " Department");

            Console.Read();
        }
    }
}
