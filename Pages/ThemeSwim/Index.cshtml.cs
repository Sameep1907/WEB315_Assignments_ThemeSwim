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
    public class IndexModel : PageModel
    {
        private readonly ThemeSwimContext _context;

        public IndexModel(ThemeSwimContext context)
        {
            _context = context;
        }

        public IList<ThemeSwim> ThemeSwim { get;set; }

        public async Task OnGetAsync()
        {
            ThemeSwim = await _context.ThemeSwim.ToListAsync();
        }
    }
}
