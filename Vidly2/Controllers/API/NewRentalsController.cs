using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using Vidly2.DTOs;
using Vidly2.Models;

namespace Vidly2.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IHttpActionResult GetNewRentals()
        {
            //return Ok("Dziala");
            return Ok(_context.Rentals.ToList());
        }
        [Route("api/AllRentals")]
        public IHttpActionResult GetRentals()
        {
            var rentals = _context.Rentals.Include(r => r.Customer).Include(r => r.Movie);

            var rentalsDtos = new List<RentalDto>();

            foreach (var rental in rentals)
            {
                var rentalDto = new RentalDto()
                {
                    Id = rental.Id,
                    CustomerId = rental.CustomerId,
                    CustomerName = rental.Customer.Name,
                    MovieId = rental.MovieId,
                    MovieName = rental.Movie.Name,
                    DateRented = rental.DateRented.ToShortDateString()
                };
                rentalsDtos.Add(rentalDto);
            }

            return Ok(rentalsDtos);
        }


        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable < 1)
                    return BadRequest("Movie is not available");
                movie.NumberAvailable--;

                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);

            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
