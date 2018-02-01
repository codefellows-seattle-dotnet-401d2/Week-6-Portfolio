using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public Projects Projects { get; set; }

        private readonly IProjectServices projectServices;

        public AddEditProjectsModel(IProjectServices pj)
        {
            projectServices = pj;
        }
        
        public async Task OnGet()
        {
            Projects = await projectServices.FindAsync(ID.GetValueOrDefault()) ?? new Projects();
        }

        public async Task<IActionResult> OnPost()
        {
            Projects rest = await projectServices.FindAsync(ID.GetValueOrDefault()) ?? new Projects();
            rest.Name = Projects.Name;
            rest.Title = Projects.Title;
            rest.Description = Projects.Description;
            rest.Skill = Projects.Skill;
          

            await projectServices.SaveAsync(rest);

            return RedirectToPage("/Restaurant", new { id = rest.ID });
        }


        public async Task<IActionResult> OnPostDelete()
        {
            await projectServices.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");

        }
        
    }


}