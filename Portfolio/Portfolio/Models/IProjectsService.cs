using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    interface IRestaurantService
    {
        Task DeleteAsync(int id);

        Projects Find(int id);

        Task<Projects> FindAsync();

        IQueryable<Projects> GetAll(int? count = null, int? page = null );

        Task<Projects[]> GetAllAsync(int? count = null, int? page = null);

        Task SaveAsync(Projects projects);
    }
}
