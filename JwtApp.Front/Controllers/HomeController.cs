using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Front.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin,Member")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AdminPage()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Member")]
        [HttpGet]
        public IActionResult MemberPage()
        {
            return View();
        }
    }
}
