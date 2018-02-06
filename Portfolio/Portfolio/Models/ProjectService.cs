using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ProjectService : IProjectService
    {
        private readonly ProjectDbContext _context;

        public ProjectService()
        {
            var options = new DbContextOptionsBuilder<ProjectDbContext>().UseInMemoryDatabase("MyProjectFinder").Options;
            _context = new ProjectDbContext(options);
        }

        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            Project projectToDelete = await _context.Projects.FindAsync(id);
            if (projectToDelete != null)
            {
                _context.Projects.Remove(projectToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public Project Find(int id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }

        public Task<Project> FindAsync(int id)
        {
            return _context.Projects.FirstOrDefaultAsync(p => p.Id == id);
        }

        public IQueryable<Project> GetAll(int? count = null, int? page = null)
        {
            int actualCount = count.GetValueOrDefault(10);
            return _context.Projects.Skip(actualCount * page.GetValueOrDefault(0)).Take(actualCount);
        }

        public Task<Project[]> GetAllAsync(int? count = null, int? page = null)
        {
            return GetAll(count, page).ToArrayAsync();
        }

        public async Task SaveAsync(Project project)
        {
            bool alreadyExists = project.Id == default(int);
            _context.Entry(project).State = alreadyExists ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
