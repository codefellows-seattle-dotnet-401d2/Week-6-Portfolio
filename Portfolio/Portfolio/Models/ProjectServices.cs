using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Models
{
    public class ProjectServices : IProjectServices
    {
        private readonly PortfolioDbContext _context;


        public ProjectServices(PortfolioDbContext context)
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


        public IQueryable<Projects> GetAll(int? count = null, int? page = null)
        {
            var actualCount = count.GetValueOrDefault(10);

            return _context.Projects
                    .Skip(actualCount * page.GetValueOrDefault(0))
                    .Take(actualCount);
        }

        public Task<Projects[]> GetAllAsync(int? count = null, int? page = null)
        {
            return GetAll(count, page).ToArrayAsync();
        }


        //
        public async Task SaveAsync(Projects projects)
        {
            var isNew = projects.ID == default(int);
            _context.Entry(projects).State = isNew ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
