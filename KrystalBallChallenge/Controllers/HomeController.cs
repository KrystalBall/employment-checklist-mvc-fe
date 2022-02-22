using Microsoft.AspNetCore.Mvc;

namespace KrystalBallChallenge.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

    }
}