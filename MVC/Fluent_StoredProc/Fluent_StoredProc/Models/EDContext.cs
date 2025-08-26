using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Fluent_StoredProc.Models
{
    public class EDContext : DbContext
    {
        public EDContext() : base("name=edmodel") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department>Departments { get; set; }


        //1. Default names along with the entityname

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().MapToStoredProcedures();
        //}


        //2. User names to stored procedure

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures(sp => sp.Insert(
                s => s.HasName("InsertEmployee", "dbo")).Update(
                s => s.HasName("UpdateEmployee", "dbo")).Delete(
                s => s.HasName("DeleteEmployee", "dbo")));
        }


        //3. map to custom stored procedures to an entity in code first

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().MapToStoredProcedures(sp => sp.Insert(
        //        s => s.HasName("InsertEmployee").Parameter(pm =>pm.EName,"EName").
        //        Parameter(pm=>pm.Salary,"Salary")).Update(
        //        s => s.HasName("UpdateEmployee").Parameter(pm=>pm.EName,"EName").
        //        Parameter(pm=> pm.Salary,"Salary")).Delete(
        //        s => s.HasName("DeleteEmployee").Parameter(pm => pm.Id, "Id")));
        //}

        //4. stored procedures for all entities

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Types().Configure(t => t.MapToStoredProcedures());
        //}
    }
}