using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            this.EnsureSeedData();
        }

        public DbSet<Project> Projects { get; set; }
    }
}
