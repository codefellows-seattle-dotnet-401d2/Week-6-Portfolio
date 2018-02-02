using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class AddEditProjectsModel : PageModel
    {
        

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        [BindProperty]
        public Projects Projects { get; set; }


        private readonly IProjectServices projectServices;


        public AddEditProjectsModel(IProjectServices pj)
        {
            projectServices = pj;
        }
        
        //on get, this method will will get the if
        public async Task OnGet()
        {
            Projects = await projectServices.FindAsync(ID.GetValueOrDefault()) ?? new Projects();
        }


        public async Task<IActionResult> OnPost()
        {
            Projects proj = await projectServices.FindAsync(ID.GetValueOrDefault()) ?? new Projects();
            proj.ID = Projects.ID;
            proj.Name = Projects.Name;
            proj.Title = Projects.Title;
            proj.Description = Projects.Description;
            proj.Skill = Projects.Skill;
            proj.ImageUrl = Projects.ImageUrl;
         

            //if the image does not exits, 
            if(Image != null)
            {
                using (var stream = new System.IO.MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    proj.Image = stream.ToArray();
                    proj.ImageContentType = Image.ContentType;
                }
            }
          

            await projectServices.SaveAsync(proj);

            return RedirectToPage("/Projects", new { id = proj.ID });
        }


        public async Task<IActionResult> OnPostDelete()
        {
            await projectServices.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");

        }
        
    }


}