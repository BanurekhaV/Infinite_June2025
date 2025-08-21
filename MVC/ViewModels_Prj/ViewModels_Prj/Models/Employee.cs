using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels_Prj.Models
{
    public class Employee
    {
        public int EID { get; set; }
        public string EName { get; set; }
        public decimal Salary { get; set; }
        public int ? AddreesId { get; set; }
    }
}