using Microsoft.AspNetCore.Mvc;

namespace ProfileTwo
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost("redirect")]
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}