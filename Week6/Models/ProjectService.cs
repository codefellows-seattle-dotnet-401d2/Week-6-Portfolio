using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week6.Data;

namespace Week6.Models
{
    public class ProjectService : IProjectService
    {
        private ProjectDbContext _context { get; set; }

        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }

        public IQueryable<Project> GetAllAsync()
        {
            return _context.Portfolio;
        }

        public Project GetAsync(int id)
        {
            return _context.Portfolio.FirstOrDefault(project => project.Id == id);
        }

        public Task PostAsync(Project project)
        {
            throw new NotImplementedException();
        }

        public Task PutAsync(Project project)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
