using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PortfolioRazorPage.Data;
using PortfolioRazorPage.Models;

namespace PortfolioRazorPage.Pages.ProjectAdmin
{
    public class DetailsModel : PageModel
    {
        private readonly PortfolioRazorPage.Data.ProjectDbContext _context;

        public DetailsModel(PortfolioRazorPage.Data.ProjectDbContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Projects.SingleOrDefaultAsync(m => m.Id == id);

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
