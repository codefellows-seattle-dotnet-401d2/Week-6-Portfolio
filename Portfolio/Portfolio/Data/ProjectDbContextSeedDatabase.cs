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

        private static Project[] GenerateProjects()
        {
            return new []
            {
                new Project
                {
                    Name = "Monster Hunter",
                    DateCompleted = new DateTime(2018, 1, 26)
                },
                new Project
                {
                    Name = "Alaska Airlines",
                    DateCompleted = new DateTime(2017, 11, 1)
                },
                new Project
                {
                    Name = "Graphica",
                    DateCompleted = new DateTime(2017, 8, 15)
                }
            };
        }
    }
}
