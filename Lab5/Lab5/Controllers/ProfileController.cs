using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "This view will display the profile of the logged-in user.";
            return View();
        }
    }
}
