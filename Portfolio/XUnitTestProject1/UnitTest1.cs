using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;
using Portfolio.Models;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        DbContextOptions<PortfolioDbContext> options = new DbContextOptionsBuilder<PortfolioDbContext>()
           .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

            [Fact]
          public async void ReturnSavedProject()
          {
              using (PortfolioDbContext _context = new PortfolioDbContext(options))
              {
                  // Arrange
                  ProjectsService controller = new ProjectsService();
                  Projects proj = new Projects()
                  {
                      Title = "Project",
                      Description = "Rad Project",
                      Technologies = "c#"
                  };

                  // Act
                 Object result = await controller.SaveAsync(proj);
                 OkObjectResult myResult = (OkObjectResult)result;

                 // Assert
                 Assert.Equal(200, myResult.StatusCode);
              }
          }
    }
}
