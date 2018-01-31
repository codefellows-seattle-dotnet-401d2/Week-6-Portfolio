using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week6.Models
{
    public class ProjectService : IProjectService
    {
        public ProjectDbContext _context { get; set; }

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
