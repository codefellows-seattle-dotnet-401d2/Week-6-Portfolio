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

        public Task GetAllAsync()
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
