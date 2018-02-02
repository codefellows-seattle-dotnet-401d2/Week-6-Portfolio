using Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Models
{
    public static class PortfolioDbContextSeed
    {
        static object synchblock = new object();
        static volatile bool seeded = false;
        public static void EnsureSeedData(PortfolioDbContext context)
        {
            if (!seeded && context.portfolioDb.Count() == 0)
            {
                lock (synchblock)
                {
                    if (!seeded)
                    {
                        var projects = GenerateProjects();
                        context.portfolioDb.AddRange(projects);
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
                Title = "MVC Deployment",

                Description = "This application provides a portal for student enrollment. You can enter the students first and last name, phone number, and house of choice(Hogwarts). You are then directed to a view all page where you can see the enrolled students. These students are saved into a SQL server database.",

                Technologies = string.Join(Environment.NewLine, new List<string> {
                        "Language: C#",
                        "MVC Core"
                    }),

                    ImageUrl = "#"
                },

                new Projects
                {
                    Title = "Building a School",

                    Description = "This application is built to showcase the principal and importance of inheritance between classes and objects. In this case, we are building a school with different types of courses. Code Fellows serves as the base class and the breakdown of courses and their properties follows",

                    Technologies = string.Join(Environment.NewLine, new List<string>
                    {
                        "Language: C#",
                        "MVC Core"
                    }),

                    ImageUrl = "#"
                }
            };     
        }
    }
}

