using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio
{
    public interface IProjectServices 
    {
        Task DeleteAsync(int id);

        Projects Find(int id);

        Task<Projects> FindAsync(int id);

        IQueryable<Projects> GetAll(int? count = null, int? page = null );

        Task<Projects[]> GetAllAsync(int? count = null, int? page = null);

        Task SaveAsync(Projects projects);

    }
}
