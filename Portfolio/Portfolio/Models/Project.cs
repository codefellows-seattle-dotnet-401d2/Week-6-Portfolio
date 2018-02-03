using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Environment;

namespace Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // mobile or desktop
        public DateTime DateCompleted { get; set; }
        public string ImgUrl { get; set; }
        public byte[] Image { get; set; }
        public string ImageContentType { get; set; }
        public List<string> Technologies { get; set; }
        public string Description { get; set; }
        public string MenuItems { get; set; } // List of Projets
        public IEnumerable<string> MenuItemsList => (MenuItems ?? string.Empty).Split(NewLine);
    }
}
