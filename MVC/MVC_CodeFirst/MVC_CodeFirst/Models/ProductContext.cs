using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVC_CodeFirst.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=connectstr") { }

        public DbSet<Products> Product { get; set; }
        public DbSet<Sales> Sale { get; set; }
    }
}