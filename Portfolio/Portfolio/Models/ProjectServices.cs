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
            _context.Projects.Remove(new Project { ID = id });
            await _context.SaveChangesAsync();
        }

        public Project Find(int id)
        {
            return _context.Projects.FirstOrDefault(x => x.ID == id);
        }

        public Task<Project> FindAsync(int id)
        {
            return _context.Projects.FirstOrDefaultAsync(x => x.ID == id);
        }

        public Task<Project> FindAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetAll(int? count = null, int? page = null)
        {
            throw new NotImplementedException();
        }

        public Task<Project[]> GetAllAsync(int? count = null, int? page = null)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(Project projects)
        {
            var isNew = projects.ID == default(int);
            _context.Entry(projects).State = isNew ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
