using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static System.Environment;

namespace Portfolio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30),Required]
        public string Name { get; set; }

        [StringLength(20), Required]
        public string Type { get; set; }

        [StringLength(200), Required]
        public string Description { get; set; }

        public DateTime DateCompleted { get; set; }

        public string ImageUrl { get; set; }
        public byte[] Image { get; set; }
        public string ImageContentType { get; set; }

        [NotMapped]
        public List<string> Technologies { get; set; }

        public string MenuItems { get; set; }
        public IEnumerable<string> MenuItemsList => (MenuItems ?? string.Empty).Split(NewLine);
    }
}
