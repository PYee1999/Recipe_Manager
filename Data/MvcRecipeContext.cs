using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipe_Manager.Models;

namespace Recipe_Manager.Data
{
    public class MvcRecipeContext : DbContext
    {
        public MvcRecipeContext (DbContextOptions<MvcRecipeContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe_Manager.Models.Recipe> Recipe { get; set; } = default!;
    }
}
