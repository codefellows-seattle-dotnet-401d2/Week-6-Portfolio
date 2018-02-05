using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    public class AddEditProjectModel : PageModel
    {
        [FromRoute]
        public int? Id { get; set; }

        [BindProperty]
        public Project Project { get; set; }

        private readonly IProjectService projectService;

        public AddEditProjectModel(IProjectService ps)
        {
            projectService = ps;
        }

        public async Task OnGet()
        {
            Project = await projectService.FindAsync(Id.GetValueOrDefault()) ?? new Project();
        }

        public async Task<IActionResult> OnPost()
        {
            await projectService.SaveAsync(Project);

            return RedirectToPage("/Project", new { id = Project.Id });
        }

        public async Task<IActionResult> onPostDelete()
        {
            await projectService.DeleteAsync(Id.Value);
            return RedirectToPage("/Index");
        }
    }
}