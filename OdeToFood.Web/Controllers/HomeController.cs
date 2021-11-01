using OdeToFood.Data.Services;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {
        // Access the database through this reference
        IRestaurantData db;
        // Constructor to call line above
        public HomeController(IRestaurantData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            // Something to invoke to carry out an action result
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}