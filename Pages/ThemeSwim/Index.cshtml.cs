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
    public class IndexModel : PageModel
    {
        private readonly ThemeSwimContext _context;

        public IndexModel(ThemeSwimContext context)
        {
            _context = context;
        }

        public IList<ThemeSwim> ThemeSwim { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Swimming { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SwimmingPool { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> CompetitionQuery = from c in _context.ThemeSwim
                                    orderby c.Competition
                                    select c.Competition;

            var Championship = from c in _context.ThemeSwim
                        select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Championship = Championship.Where(s => s.PoolName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SwimmingPool))
            {
                Championship = Championship.Where(x => x.Competition == SwimmingPool);
            }
            Swimming = new SelectList(await CompetitionQuery.Distinct().ToListAsync());
            ThemeSwim = await Championship.ToListAsync();
        }
    }
}
