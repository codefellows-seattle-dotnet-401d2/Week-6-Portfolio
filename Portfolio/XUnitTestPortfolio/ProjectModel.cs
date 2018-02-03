using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestPortfolio
{
    public class ProjectModel
    {
        [Fact]
        public void GetId()
        {
            // Arrange & Act
            Project project = new Project { Id = 2 };

            // Assert
            Assert.Equal(2, project.Id);
        }

        [Fact]
        public void GetName()
        {
            // Arrange & Act
            Project project = new Project { Name = "Micky" };

            // Assert
            Assert.Equal("Micky", project.Name);
        }
        
        [Fact]
        public void SetId()
        {
            // Arrange & Act
            Project project = new Project { Id = 5 };
            project.Id = 11;

            // Assert
            Assert.Equal(11, project.Id);
        }
    }
}
