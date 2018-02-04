using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public static class ProjectDbContextSeed
    {
        static object synchblock = new object();
        static volatile bool seeded = false;

        public static void EnsureSeedData(this ProjectDbContext context)
        {
            if(!seeded && context.Projects.Count() == 0)
            {
                lock (synchblock)
                {
                    if (!seeded)
                    {
                        var projects = GenerateProjects();
                        context.Projects.AddRange(projects);
                        context.SaveChanges();
                        seeded = true;
                    }
                }
            }
        }

        public static Project[] GenerateProjects()
        {
            return new Project[]
            {
                new Project
                {
                    Name = "Dummy Project Name 1",
                    Description = "Dummy Project Description",
                    SkillItems = string.Join(Environment.NewLine, new List<string>
                    {
                        "C#", "ASP.NET", "Razor Pages"
                    }),
                    ImageUrl = "~/Images/MHxHZD.png",
                },
                new Project
                {
                    Name = "Dummy Project Name 2",
                    Description = "Dummy Project Description",
                    SkillItems = string.Join(Environment.NewLine, new List<string>
                    {
                        "C#", "ASP.NET", "Razor Pages"
                    }),
                    ImageUrl = "~/Images/MHxHZD.png",
                },
                new Project
                {
                    Name = "Dummy Project Name 3",
                    Description = "Dummy Project Description",
                    SkillItems = string.Join(Environment.NewLine, new List<string>
                    {
                        "C#", "ASP.NET", "Razor Pages"
                    }),
                    ImageUrl = "~/Images/MHxHZD.png",
                },
                new Project
                {
                    Name = "Dummy Project Name 4",
                    Description = "Dummy Project Description",
                    SkillItems = string.Join(Environment.NewLine, new List<string>
                    {
                        "C#", "ASP.NET", "Razor Pages"
                    }),
                    ImageUrl = "~/Images/MHxHZD.png",
                },
                new Project
                {
                    Name = "Dummy Project Name 5",
                    Description = "Dummy Project Description",
                    SkillItems = string.Join(Environment.NewLine, new List<string>
                    {
                        "C#", "ASP.NET", "Razor Pages"
                    }),
                    ImageUrl = "~/Images/MHxHZD.png",
                },
            };
        }
    }
}
