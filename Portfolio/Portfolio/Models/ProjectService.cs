using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ProjectService : IProjectService
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Project FindProject(int id)
        {
            throw new NotImplementedException();
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

        public Task SaveAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
