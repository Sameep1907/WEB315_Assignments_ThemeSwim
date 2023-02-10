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
    public class DeleteModel : PageModel
    {
        private readonly ThemeSwimContext _context;

        public DeleteModel(ThemeSwimContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ThemeSwim = await _context.ThemeSwim.FindAsync(id);

            if (ThemeSwim != null)
            {
                _context.ThemeSwim.Remove(ThemeSwim);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
