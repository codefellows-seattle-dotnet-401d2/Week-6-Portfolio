using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Environment;

namespace Portfolio.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ProfileDescription { get; set; }

        public List<string> ProgrammingLanguages { get; set; }

        public List<string> CloudServersDeployment { get; set; }

        public string MenuItems { get; set; }

        public IEnumerable<string> MenuItemsList => (MenuItems ?? string.Empty).Split(NewLine);

        public List<Project> Projects { get; set; }
    }
}
