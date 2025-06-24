using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeManagment.Models
{
    public class RecipeStatus
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public bool IsFavorite { get; set; }
        public bool ToTry { get; set; }
        public bool MadeBefore { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}