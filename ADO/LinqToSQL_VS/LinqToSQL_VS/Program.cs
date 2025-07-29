using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL_VS
{
    class Program
    {
        static LS_VSDataContext db = new LS_VSDataContext();  //inoke the empty constructor
        static void Main(string[] args)
        {
            var emp = db.emps.ToList();

            foreach(var e in emp)
            {
                Console.WriteLine($"{e.empno} {e.ename} {e.job} {e.salary} {e.mgr_id}");
            }

            Console.WriteLine("-----Calling The Procedure------");
            double ? salary = 0;
            string ename = "Vidushi";
            db.GetSal_byName(ename, ref salary);
            Console.WriteLine($"{ename} earns a Salary of {salary} Rupees..");
            Console.Read();
        }
    }
}
