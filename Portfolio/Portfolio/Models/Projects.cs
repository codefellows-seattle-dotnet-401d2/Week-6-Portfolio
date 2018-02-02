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

        public byte[] Image { get; set; }

        public string ImageContentType { get; set; }

        public IEnumerable<string> AdditionalSkills
        {
            get { return (Skill ?? String.Empty).Split(NewLine); }
        }

       
        public string GetInlineImageSrc()
        {
            if (Image == null || ImageContentType == null)
                return null;

            var base64Image = System.Convert.ToBase64String(Image);
            return $"data:{ImageContentType};base64,{base64Image}";
        }

        public void SetImage(Microsoft.AspNetCore.Http.IFormFile file)
        {
            if (file == null)
                return;

            ImageContentType = file.ContentType;

            using (var stream = new System.IO.MemoryStream())
            {
                file.CopyTo(stream);
                Image = stream.ToArray();
            }
        }

    }
}
