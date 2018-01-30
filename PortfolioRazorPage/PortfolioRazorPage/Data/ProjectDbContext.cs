using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortfolioRazorPage.Models;

namespace PortfolioRazorPage.Data
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Project> Project { get; set; }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }
    }
}
