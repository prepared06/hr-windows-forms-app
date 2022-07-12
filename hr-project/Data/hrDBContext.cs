using Microsoft.EntityFrameworkCore;
using hr_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_project.Data
{
    internal class hrDBContext: DbContext
    {    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hrDb;Trusted_Connection=True;MultipleActiveResultSets=true");//added ;Trusted_Connection=True;MultipleActiveResultSets=true
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne<Position>(s => s.JobTitle)
                .WithMany(g => g.Employees)
                .HasForeignKey(s => s.CurrentJobTitleId);

            modelBuilder.Entity<Employee>()
                .HasOne<Department>(s => s.Department)
                .WithMany(g => g.Employees)
                .HasForeignKey(s => s.CurrentDepartmentId);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public object Employee { get; internal set; }
    }
}
