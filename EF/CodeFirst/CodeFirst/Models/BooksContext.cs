using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst.Models
{
    class BooksContext : DbContext
    {
        public BooksContext() : base("name=BooksConnection") { }

        public DbSet<Books> book { get; set; }
        public DbSet<Authors> author { get; set; }
    }
}
