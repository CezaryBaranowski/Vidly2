using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly2.ViewModels
{
    public class MovieFormViewModel
    {

        public MovieFormViewModel()
        {
            Id = 0;
        }
        
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            ReleasedDate = movie.ReleasedDate;
            DateAdded = movie.DateAdded;
            NumberInStock = movie.NumberInStock;
        }

        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Date Released")]
        public DateTime? ReleasedDate { get; set; }

        [DateAddedGreaterThanDateReleased]
        [Required]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        public string Title => Id == null ? "New Movie" : "Edit Movie";
    }
}