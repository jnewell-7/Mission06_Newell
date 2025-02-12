using System.ComponentModel.DataAnnotations;

namespace Mission06_Newell.Models
{
    public class AddMovie
    {
        [Key] // Primary Key
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Movie title is required")]
        public string MovieTitle { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2100, ErrorMessage = "Enter a valid year between 1888 and 2100")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }

        public bool Edited { get; set; } // Nullable to allow deselection
        
        public string? LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot exceed 25 characters")]
        public string? Notes { get; set; }
    }
}