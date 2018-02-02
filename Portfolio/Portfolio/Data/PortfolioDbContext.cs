using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<Projects> portfolioDb { get; set; }

        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
           //this.EnsureSeedData();
        }
    }
}
