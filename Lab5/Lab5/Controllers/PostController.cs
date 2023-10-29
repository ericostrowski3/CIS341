using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Details(int id)
        {
            // When a user clicks a post from the home page, this view will display that post
            ViewBag.Message = $"This view will display details for post with ID: {id}";

            return View();
        }
    }
}
