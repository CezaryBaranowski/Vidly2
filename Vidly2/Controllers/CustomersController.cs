using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        private RandomMovieViewModel viewModel;
        public CustomersController()
        {
            var movies = new List<Movie>()
            {
                new Movie { Name = "Shrek"},
                new Movie { Name = "Wall-e"}
            };
            viewModel = new RandomMovieViewModel();
            var customers = new List<Customer>()
            {
                new Customer(1, "John Smith"),
                new Customer(2, "Mary Williams")
            };
            viewModel.Movies = movies;
            viewModel.Customers = customers;
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View(viewModel);
        }
        [Route("customer/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = viewModel.Customers.FirstOrDefault(c=>c.Id==id);
            CustomerDetailsViewModel customerDetailsViewModel = new CustomerDetailsViewModel
            {
                Customer = customer   
            };
            if (customerDetailsViewModel.Customer != null)
                return View(customerDetailsViewModel);
            else return HttpNotFound();
        }
    }
}