using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    public class AppDbContext : DbContext
    {
        public DbSet<project> Pro { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<emplyeprofil> emppro { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=YourDatabaseName;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.department)
                .WithMany(d => d.Employees).
                HasForeignKey(k => k.DepartmentID);

            modelBuilder.Entity<emplyeprofil>().HasOne(x => x.project1).WithOne(c => c.emplyeprofil1).HasForeignKey(k => k.emplyeprofilid);
        }
    }
}
