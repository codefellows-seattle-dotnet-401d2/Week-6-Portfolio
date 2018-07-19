using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week6.Models;

namespace Week6.Data
{
    public class ProjectDbContext : DbContext 
    {
        public DbSet<Project> Project { get; set; }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }
    }
}
