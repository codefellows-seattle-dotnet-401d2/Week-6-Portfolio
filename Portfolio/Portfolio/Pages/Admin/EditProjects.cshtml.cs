using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class EditProjectsModel : PageModel
    {
        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Projects Project { get; set; }

        /// <summary>
        /// Dependency Injection
        /// </summary>
        private readonly IProjectsService projectService;

        public EditProjectsModel(IProjectsService projServ)
        {
            projectService = projServ;
        }

        /// <summary>
        /// This is what gets loaded everytime the page gets rendered
        /// </summary>
        /// <returns>Returns project selected</returns>
        public async Task OnGet()
        {
            Project = await projectService.FindAsync(ID.GetValueOrDefault()) ?? new Projects();
        }

        /// <summary>
        /// This updates the project
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> OnPost()
        {
            Projects proj = await projectService.FindAsync(ID.GetValueOrDefault()) ?? new Projects();

            // sets everything in the Projects object to the new Project
            proj.Title = Project.Title;
            proj.Description = Project.Description;
            proj.Technologies = Project.Technologies;

            // saves our new Project created into SaveAsync
            await projectService.SaveAsync(proj);

            // once saved, redirect to our page with the new project added
            return RedirectToPage("/Projects", new { id = proj.ID });
        }
    }
}