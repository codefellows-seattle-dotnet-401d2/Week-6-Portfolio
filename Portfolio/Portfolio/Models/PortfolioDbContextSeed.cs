using Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public static class PortfolioDbContextSeed
    {

        static object synchblock = new object();
        static volatile bool seeded = false;
        public static void EnsureSeedData(this PortfolioDbContext context)
        {
            if (!seeded && context.Projects.Count() == 0)
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

        public static Projects[] GenerateProjects()
        {
            return new Projects[]
            {
                new Projects
            {
                Name = "add info here",

                Title = "add info here",

                Description ="add info here",

                Skill = string.Join(Environment.NewLine, new List<string> {
                        "add skill here",
                        "add skill here"
                    }),

                    ImageUrl = "place image path here"
                },

                new Projects
            {
                Name = "add info here",

                Title = "add info here",

                Description ="add info here",

                Skill = string.Join(Environment.NewLine, new List<string> {
                        "add skill here",
                        "add skill here"
                    }),

                    ImageUrl = "place image path here"
                },

                new Projects
            {
                Name = "add info here",

                Title = "add info here",

                Description ="add info here",

                Skill = string.Join(Environment.NewLine, new List<string> {
                        "add skill here",
                        "add skill here"
                    }),

                    ImageUrl = "place image path here"
                },
            };
        }
    }
}
