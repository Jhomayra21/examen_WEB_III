using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        // Clave Primaria (PK)
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } 

        [Required]
        public string Instructions { get; set; } 

        public int PreparationTime { get; set; } 

        public int CookingTime { get; set; } 

        public int Servings { get; set; } 

        public string ImageUrl { get; set; } 
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}