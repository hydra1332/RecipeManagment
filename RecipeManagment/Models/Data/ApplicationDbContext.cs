
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace RecipeManagment.Models.Data
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeStatus> RecipeStatuses { get; set; }

        public ApplicationDbContext() : base("DefaultConnection") { }
    }

}