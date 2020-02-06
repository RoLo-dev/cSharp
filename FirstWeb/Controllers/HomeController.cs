using Microsoft.AspNetCore.Mvc;

namespace FirstWeb
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string Index()
        {
            return "Hello From Controller";
        }

        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi Again!";
        }
    }
}