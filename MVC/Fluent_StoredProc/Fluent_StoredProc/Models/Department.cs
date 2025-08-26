using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Fluent_StoredProc.Models
{
    public class Department
    {
        [Key]
        public int DId { get; set; }
        public string DName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}