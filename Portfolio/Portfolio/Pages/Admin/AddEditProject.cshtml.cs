using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models;

namespace Portfolio.Pages.Admin
{
    [Authorize]
    public class AddEditProjectModel : PageModel
    {
        [FromRoute]
        public int? Id { get; set; }

        [BindProperty]
        public Project Project { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

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
            Project proj = await projectService.FindAsync(Id.GetValueOrDefault()) ?? new Project();

            if (Project.Name != null && Project.Name != "") proj.Name = Project.Name;
            if (Project.Description != null && Project.Description != "") proj.Description = Project.Description;
            if (Project.SkillItems != null && Project.SkillItems != "") proj.SkillItems = Project.SkillItems;
            if (Project.ImageUrl != null && Project.ImageUrl != "") proj.ImageUrl = Project.ImageUrl;

            if (Image != null)
            {
                using(var stream = new System.IO.MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    proj.Image = stream.ToArray();
                    proj.ImageContentType = Image.ContentType;
                }
            }

            await projectService.SaveAsync(proj);
            // proj = await projectService.FindAsync(Id.GetValueOrDefault());
            return RedirectToPage("/Project", new { id = proj.Id });
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await projectService.DeleteAsync(Id.Value);
            return RedirectToPage("/Index");
        }
    }
}