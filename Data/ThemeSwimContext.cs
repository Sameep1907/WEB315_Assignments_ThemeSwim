using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB315_Assignments_ThemeSwim.Models;

    public class ThemeSwimContext : DbContext
    {
        public ThemeSwimContext (DbContextOptions<ThemeSwimContext> options)
            : base(options)
        {
        }

        public DbSet<WEB315_Assignments_ThemeSwim.Models.ThemeSwim> ThemeSwim { get; set; }
    }
