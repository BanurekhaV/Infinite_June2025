using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CodeFirst.Models
{
    public class Sales
    {
        [Key]
        public int SaleID { get; set; }
        public DateTime Saledate { get; set; }
        public int QtySold { get; set; }
        public double SaleAmount { get; set; }

        public ICollection<Products>Product { get; set; }
    }
}