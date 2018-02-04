using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public interface IProjectService
    {
        Task DeleteAsync(int id);
        Project FindProject(int id);
        Task<Project> FindAsync(int id);
        IQueryable<Project> GetAll(int? count = null, int? page = null);
        Task<Project[]> GetAllAsync(int? count = null, int? page = null);
        Task SaveAsync(Project project);
    }
}
