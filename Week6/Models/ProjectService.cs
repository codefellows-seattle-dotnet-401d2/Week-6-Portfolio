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
        private readonly ProjectDbContext _context { get; set; }

        public ProjectService()
        {
            DbContextOptions<ProjectDbContext> options = new DbContextOptionsBuilder<ProjectDbContext>()
                //################################### SOME STUFF NEEDS TO GO HERE!
            _context = new ProjectDbContext(options);
        }

        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }

        public Task GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetAsync(int id)
        {
            throw new NotImplementedException();
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
