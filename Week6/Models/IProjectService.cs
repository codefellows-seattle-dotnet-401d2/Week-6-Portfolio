using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week6.Models
{
    public interface IProjectService
    {
        IQueryable<Project> GetAllAsync();

        Project GetAsync(int id);

        Task PostAsync(Project project);

        Task PutAsync(Project project);

        Task DeleteAsync(int id);
    }
}
