using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeManagment.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string CuisineType { get; set; }
        public int PreparationTimeInMinutes { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public string Metadata { get; set; }

        // Status tags
        public bool IsFavorite { get; set; }
        public bool ToTry { get; set; }
        public bool MadeBefore { get; set; }
    }
}