using HCL_CodeFirst.BusinessEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_CodeFirst.DatabaseLogic.DbConnect
{
    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AM7K2K6;initial Catalog=HCL_CodeFirst1;Integrated Security=True");
        }
    }
}
