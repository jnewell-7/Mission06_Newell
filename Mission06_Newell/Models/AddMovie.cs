using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Newell.Models
{
    public class AddMovie
    {
        
        [Key] // Primary Key
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie title is required")]
        public string Title { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2100, ErrorMessage = "Enter a valid year between 1888 and 2100")]
        public int Year { get; set; }

        public string? Director { get; set; }
        
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; } // Nullable to allow deselection
        
        public string? LentTo { get; set; }
        
        [Required]
        public bool CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters")]
        public string? Notes { get; set; }
    }
}