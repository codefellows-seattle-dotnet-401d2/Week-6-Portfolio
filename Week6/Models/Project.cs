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
        public List<string> Images { get; set;  }
        public string Description { get; set; }
        public string Languages { get; set; }
        public string Repository { get; set; }


    }
}
