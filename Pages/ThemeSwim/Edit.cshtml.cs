using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB315_Assignments_ThemeSwim.Models;

namespace WEB315_Assignments_ThemeSwim.Pages_ThemeSwim
{
    public class EditModel : PageModel
    {
        private readonly ThemeSwimContext _context;

        public EditModel(ThemeSwimContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ThemeSwim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThemeSwimExists(ThemeSwim.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ThemeSwimExists(int id)
        {
            return _context.ThemeSwim.Any(e => e.ID == id);
        }
    }
}
