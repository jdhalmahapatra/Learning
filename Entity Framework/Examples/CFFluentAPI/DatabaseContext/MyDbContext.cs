using CFFluentAPI.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFluentAPI.DatabaseContext
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=Constr")
        {

        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Entity Configuration of "Department" Entity
            modelBuilder.Entity<Department>().ToTable("Dept");

            //Primary Key Configuration
            modelBuilder.Entity<Department>().HasKey(d => d.DeptId); //Department

            modelBuilder.Entity<Employee>().HasKey(ea => ea.EmpId); //EmployeeAddress

            //Property Configuration of "Employee" Entity
            modelBuilder.Entity<Employee>().Property(e => e.EmpId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Employee>().Property(e => e.EmpName).HasColumnName("Name")
                                                                    .IsRequired()
                                                                    .HasMaxLength(50)
                                                                    .HasColumnType("varchar");

            modelBuilder.Entity<Employee>().Property(e => e.ContactNo).IsRequired()
                                                                      .HasColumnType("varchar")
                                                                      .HasMaxLength(12);


            //Create One-to-One relationship between Employee and EmployeeAddress
            modelBuilder.Entity<Employee>().HasOptional(e => e.EmployeeAddress)
                                           .WithRequired(ea => ea.Employee);

            //Create One-to-Many relationship between Department and Employee
            modelBuilder.Entity<Department>().HasMany(d => d.Employees)
                                             .WithRequired(e => e.Department)
                                             .HasForeignKey(e => e.DeptId);

            //Create One-to-Many relationship between Team and Employee
            modelBuilder.Entity<Team>().HasMany(t => t.Employees)
                                       .WithOptional(e => e.Team)
                                       .HasForeignKey(e => e.TeamId);


            //Create Many-to-Many realtionship between Project and Employee
            modelBuilder.Entity<Employee>().HasMany(e => e.Projects)
                .WithMany(p => p.Employees)
                .Map(ep =>
                {
                    ep.MapLeftKey("EmpId");
                    ep.MapRightKey("ProjectId");
                    ep.ToTable("ProjectsOfEmployees");
                });
        }
    }
}
