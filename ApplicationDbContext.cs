using Company.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer(" Data Source=(local); Initial Catalog=CompanyEFCore; Integrated Security=true; TrustServerCertificate=True ");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Dept_Locations> dept_Locations { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<works_on> works_Ons { get; set; }
        public DbSet<Dependent> Dependents { get; set; }

    }

    



}