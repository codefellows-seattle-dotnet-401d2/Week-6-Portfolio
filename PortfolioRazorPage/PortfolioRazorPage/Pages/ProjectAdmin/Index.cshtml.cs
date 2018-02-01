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
    public class IndexModel : PageModel
    {
        private readonly PortfolioRazorPage.Data.ProjectDbContext _context;

        public IndexModel(PortfolioRazorPage.Data.ProjectDbContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        public async Task OnGetAsync()
        {
            Project = await _context.Projects.ToListAsync();
        }
    }
}
