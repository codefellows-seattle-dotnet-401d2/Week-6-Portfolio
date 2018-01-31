using Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class PortfolioDbContextSeed
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

        public static Project[] GenerateProjects()
        {
            return new Project[]
            {
                new Project
            {
                Name = "add info here",

                Title = "add infor here",

                Description = string.Join(Environment.NewLine, new List<string> {
                        "add info here",
                        "add infor here"
                    }),

                    ImageUrl = "place image path here"
                },

                new Project
                {
                    Name = "add info here",

                    Title = "add info here",

                    Description = string.Join(Environment.NewLine, new List<string>
                    {
                        "add info here",
                        "add info here"
                    }),

                    ImageUrl = "place image path here"
                }
            };
        }
    }
}
