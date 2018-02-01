using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Environment;
namespace Portfolio.Models
{
    public class Projects
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Skill { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<string> AdditionalSkills
        {
            get { return (Skill ?? String.Empty).Split(NewLine); }
        }

    }
}
