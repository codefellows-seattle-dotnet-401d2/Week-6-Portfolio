using System;
using System.Threading.Tasks;
using Portfolio.Data;
using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Portfolio.Models;

namespace XUnitTestPortfolio
{
    public class UnitTestProjectService
    {
        public static DbContextOptions<ProjectDbContext> TestingDbContextOptions()
        {
            // Create a new service provider to create a new in-memory database.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            // Create a new options instance using an in-memory database and 
            // IServiceProvider that the context should resolve all of its 
            // services from.
            var builder = new DbContextOptionsBuilder<ProjectDbContext>()
                .UseInMemoryDatabase("InMemoryDb")
                .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }

        [Fact]
        public async Task DeleteProjectAsync_ProjectIsDeleted_WhenFound() 
        {
            using (var _context = new ProjectDbContext(TestingDbContextOptions()))
            {
                // Arrange
                var seedProjects = _context.Projects.ToList();

                var recordId = 1;
                var expectedProjects = seedProjects.Where(p => p.Id != recordId).ToList();

                var projectService = new ProjectService(_context);

                // Act
                await projectService.DeleteAsync(recordId);

                // Assert
                var actualProjects = await _context.Projects.ToListAsync();
                Assert.Equal(expectedProjects.OrderBy(x => x.Id), actualProjects.OrderBy(x => x.Id));
            }
        }
    }
}
