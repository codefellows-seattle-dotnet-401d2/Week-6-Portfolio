using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    interface IProjectService
    {
        Task DeleteAsync(int id);
        Project Find(int id);
        Task<Project> FindAsync();
        IQueryable<Project> GetAll(int? count = null, int? page = null);
        Task<Project[]> GetAllAsync(int? count = null, int? page = null);
        Task SaveAsync(Project project);
    }
}
