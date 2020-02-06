using Microsoft.AspNetCore.Mvc;

namespace ProfileAssignment
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }
        [Route("projects")]
        [HttpGet]
        public string Projects()
        {
            return "These are my projects";
        }
        [Route("contact")]
        [HttpGet]
        public string Contact()
        {
            return "This is my contact";
        }
    }
}