using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB315_Assignments_ThemeSwim.Models;

namespace WEB315_Assignments_ThemeSwim.Pages_ThemeSwim
{
    public class DetailsModel : PageModel
    {
        private readonly ThemeSwimContext _context;

        public DetailsModel(ThemeSwimContext context)
        {
            _context = context;
        }

        public ThemeSwim ThemeSwim { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ThemeSwim = await _context.ThemeSwim.FirstOrDefaultAsync(m => m.ID == id);

            if (ThemeSwim == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
