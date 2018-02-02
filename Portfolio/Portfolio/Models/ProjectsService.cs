using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Models
{
    public class ProjectsService : IProjectsService
    {
        private readonly PortfolioDbContext _context;

        // removed constructor with inmemory database here
        

        public ProjectsService(PortfolioDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Remove or Delete a selected project by id
        /// </summary>
        /// <param name="id">Int id</param>
        /// <returns>doesn't return</returns>
        public async Task DeleteAsync(int id)
        {
            _context.portfolioDb.Remove(new Projects { ID = id });
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Find ID of project
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>Returns id from project</returns>
        public Projects Find(int id)
        {
            return _context.portfolioDb.FirstOrDefault(x => x.ID == id);
        }

        /// <summary>
        /// Async Find ID of project
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>Returns id from project</returns>
        public Task<Projects> FindAsync(int id)
        {
            return _context.portfolioDb.FirstOrDefaultAsync(x => x.ID == id);
        }

        /// <summary>
        /// Gets all of the projects
        /// </summary>
        /// <returns>Returns ALL projects</returns>
        public IQueryable<Projects> GetAll(int? count = null, int? page = null)
        {
            var actualCount = count.GetValueOrDefault(10);

            return _context.portfolioDb
                    .Skip(actualCount * page.GetValueOrDefault(0))
                    .Take(actualCount);
        }

        /// <summary>
        /// Gets all of the projects
        /// </summary>
        /// <returns>Returns ALL projects</returns>
        public Task<Projects[]> GetAllAsync(int? count = null, int? page = null)
        {
            return GetAll(count, page).ToArrayAsync();
        }

        /// <summary>
        /// Saves a new project 
        /// </summary>
        /// <param name="projects">Object object</param>
        /// <returns>Returns a new project</returns>
        public async Task SaveAsync(Projects projects)
        {
            var saved = projects.ID == default(int);
            _context.Entry(projects).State = saved ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
