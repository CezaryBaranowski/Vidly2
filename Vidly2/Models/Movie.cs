using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Display(Name = "Date Released")]
        public DateTime? ReleasedDate { get; set; }

        [DateAddedGreaterThanDateReleased]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        [Display(Name = "Number of Available")]
        public int NumberAvailable { get; set; }
    }
}