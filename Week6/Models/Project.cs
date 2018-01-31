using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week6.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string[] Images { get; set;  }
        public string Description { get; set; }
        public string Languages { get; set; }
        public string Repository { get; set; }

        public Project(string title, string date, string[] images, string description, string languages, string repository)
        {
            Title = title;
            Date = date;
            Images = images;
            Description = description;
            Languages = languages;
            Repository = repository;
        }
    }
}
