using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRazorPage.Models
{
    interface IProjectService
    {
        Project Get(int id);
        Task<Project> GetAsync();

        IQueryable<Project> GetAll(int? count = null, int? page = null);
        Task<Project[]> GetAllAsync(int? count = null, int? page = null);

        Task DeleteAsync(int id);
        Task SaveAsync(Project project);
    }
}
