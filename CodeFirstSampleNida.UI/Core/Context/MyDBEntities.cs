using CodeFirstSampleNida.UI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSampleNida.UI.Core.Context
{
    public class MyDBEntities : DbContext
    {
        public MyDBEntities() : base("data source=.;initial catalog=VarlıkDB;integrated security=true;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            #region MyRegion
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Employee>()
            //    .HasKey(a => a.EmployeeID)
            //    .ToTable("Employee");


            //composite key
            //modelBuilder.Entity<Customer>()
            //    .HasMany(a => a.Employees)
            //    .WithMany(a => a.Customers)
            //    .Map(map =>
            //    {
            //        map.ToTable("CustomerEmployee");
            //        map.MapLeftKey("CustomerID");
            //        map.MapRightKey("EmployeeID");
            //    });


            //modelBuilder.Entity<CustomerEmployee1>()
            //    .HasKey(a => new { a.CustomerID, a.EmployeeID });


            ////conditional mapping
            //modelBuilder.Entity<Customer>()
            //    .HasKey(a => a.CustomerID)
            //    .Map(a => a.Requires("Aktifmi")
            //    .HasValue("0"))
            //    .Ignore(a => a.Aktifmi)
            //    .ToTable("Customer"); 
            #endregion

            modelBuilder.Entity<Employee>()
                .HasMany(a => a.CustomerEmployees1)
                .WithRequired(a => a.Employee);

            modelBuilder.Entity<Customer>()
                .HasMany(a => a.CustomerEmployees1)
                .WithRequired(a => a.Customer);

            modelBuilder.Entity<Customer>()
                .Property(a => a.Phone)
                .HasMaxLength(20)
                .IsRequired();

          
                

            modelBuilder.Entity<CustomerEmployee1>()
                .HasKey(a => new { a.EmployeeID, a.CustomerID });

                

          
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<CustomerEmployee1> customerEmployees1 { get; set; }
    }
}
