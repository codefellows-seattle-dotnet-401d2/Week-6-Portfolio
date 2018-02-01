using PortfolioRazorPage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRazorPage.Models
{
    public class ProjectService : IProjectService
    {
        private ProjectDbContext _context;

        public ProjectService(ProjectDbContext context)
        {
            _context = context;
        }


        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetAsync()
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

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
