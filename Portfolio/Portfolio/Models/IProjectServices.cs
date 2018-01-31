using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio
{
    interface IProjectServices 
    {
        Task DeleteAsync(int id);

        Project Find(int id);

        Task<Project> FindAsync();

        IQueryable<Project> GetAll(int? count = null, int? page = null );

        Task<Project[]> GetAllAsync(int? count = null, int? page = null);

        Task SaveAsync(Project projects);

    }
}
