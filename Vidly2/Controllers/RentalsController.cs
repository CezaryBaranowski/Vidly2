using System.Web.Mvc;

namespace Vidly2.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }

        public ActionResult All()
        {
            return View("Rentals");
        }

        public ActionResult Delete()
        {
            return View("Rentals");
        }


    }
}