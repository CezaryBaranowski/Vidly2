using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly2.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Movie Movie { get; set; }
        [Required]
        public int MovieId { get; set; }

        [Required]
        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }

    }
}