using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Data
{
    public static class ProjectDbContextSeedDatabase
    {
        private static object synchlock = new object();
        private static volatile bool seeded = false;

        public static void EnsureSeedData(this ProjectDbContext context)
        {
            lock (synchlock)
            {
                if (!seeded && !context.Projects.Any())
                {
                    Project[] projects = GenerateProjects();
                    context.Projects.AddRange(projects);
                    context.SaveChanges();
                    seeded = true;
                }
            }
        }

        public static Project[] GenerateProjects()
        {
            return new []
            {
                new Project
                {
                    Name = "Monster Hunter",
                    DateCompleted = new DateTime(2018, 1, 26),
                    Description = "From the Monster Hunter Game!",
                    Type = "Web App"
                },
                new Project
                {
                    Name = "Alaska Airlines",
                    DateCompleted = new DateTime(2017, 11, 1),
                    Description = "AirLines flights reservation web App.",
                    Type = "WebApp"
                },
                new Project
                {
                    Name = "Graphica",
                    DateCompleted = new DateTime(2017, 8, 15),
                    Description = "Desktop application for drawing shapes; Paint App clone.",
                    Type = "Desktop App"
                }
            };
        }
    }
}
