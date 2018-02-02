using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week6.Data;

namespace Week6.Models
{
    public static class ProjectDbContextSeedDatabase
    {
        static object synclock = new object();

        static volatile bool seeded = false;

        public static void EnsureSeedData(this ProjectDbContext context)
        {
            if(!seeded && context.Portfolio.Count() == 0)
            {
                lock(synclock){
                    Project[] projects = GenerateProjects();
                    context.Portfolio.AddRange();
                    context.SaveChanges();
                    seeded = true;
                }
            }
        }

        private static Project[] GenerateProjects()
        {
            return new Project[]
            {
                new Project(
                    "Project Portfolio",
                    "February 2018",
                    "http://placeholder.pics/svg/800x600",
                    "A showcase for all my favorite work.",
                    "C#, ASP.Net, MVC/Razor Pages",
                    "https://github.com/VergilPrime/Week-6-Portfolio-1"
                )
            };
        }
    }
}
