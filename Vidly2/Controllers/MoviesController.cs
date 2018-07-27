using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        private RandomMovieViewModel viewModel;

        public MoviesController()
        {
            var movies = new List<Movie>()
            {
                new Movie { Name = "Shrek"},
                new Movie { Name = "Wall-e"}
            };
            viewModel = new RandomMovieViewModel();
            var customers = new List<Customer>()
            {
                new Customer("John Smith"),
                new Customer("Mary Williams")
            };
            viewModel.Movies = movies;
            viewModel.Customers = customers;
        }
        // GET: Movies
        public ActionResult Random()
        {
        
            return View(viewModel);
            //return View(movie);
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id = " + Id);
        }

        public ActionResult Index(int? page, string sortBy)
        {
            //if (!page.HasValue)
            //{
            //    page = 1;
            //}

            //if (String.IsNullOrWhiteSpace(sortBy))
            //{
            //    sortBy = "Name";
            //}

            //return Content(String.Format("page = {0}&sortBy = {1}", page, sortBy));
            return View(viewModel);

        }

        [Route("movies/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}