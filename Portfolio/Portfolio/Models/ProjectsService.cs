using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data;
using Portfolio.Models;

namespace Week6Demo.Models
{
    public class ProjectsService : IProjectsService
    {
        private readonly PortfolioDbContext _context;


        public ProjectsService()
        {
            // TODO: CHANGE THIS(delete?), don't use in memory database
            var options = new DbContextOptionsBuilder<PortfolioDbContext>()
                .UseInMemoryDatabase("MyProjectsFinder")
                .Options;
            _context = new PortfolioDbContext(options);

        }
        public ProjectsService(PortfolioDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Projects.Remove(new Projects { ID = id });
            await _context.SaveChangesAsync();
        }

        public Projects Find(int id)
        {
            return _context.Projects.FirstOrDefault(x => x.ID == id);
        }

        public Task<Projects> FindAsync(int id)
        {
            return _context.Projects.FirstOrDefaultAsync(x => x.ID == id);
        }


 
        public async Task SaveAsync(Projects projects)
        {
            var isNew = projects.ID == default(int);
            _context.Entry(projects).State = isNew ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
