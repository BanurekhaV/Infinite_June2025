using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HTML_HelpersPrj.Models
{
    public class Student
    {
        [Display(Name ="Students Roll No :")]
        public int RNo { get; set; }
        [Display(Name="Students Name :")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}