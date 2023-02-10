using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB315_Assignments_ThemeSwim.Models;

namespace WEB315_Assignments_ThemeSwim.Pages_ThemeSwim
{
    public class CreateModel : PageModel
    {
        private readonly ThemeSwimContext _context;

        public CreateModel(ThemeSwimContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ThemeSwim ThemeSwim { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ThemeSwim.Add(ThemeSwim);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
