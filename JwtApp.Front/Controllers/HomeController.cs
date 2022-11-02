using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Front.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
