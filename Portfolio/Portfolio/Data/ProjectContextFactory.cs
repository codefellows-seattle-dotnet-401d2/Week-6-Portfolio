using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Portfolio.Data
{
    public class ProjectContextFactory : IDesignTimeDbContextFactory<ProjectDbContext>
    {
        public ProjectDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjectDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PortfolioDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            // optionsBuilder.UseSqlite("Data Source=blog.db");

            return new ProjectDbContext(optionsBuilder.Options);
        }
    }
}
