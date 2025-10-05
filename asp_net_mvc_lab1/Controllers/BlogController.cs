using asp_net_mvc_lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_lab1.Controllers
{
    public class BlogController(ILogger<BlogController> logger) : Controller
    {
        public IActionResult Index()
        {
            return View(new BlogViewModel() { 
                Title = "WelcomePageExtensions to My Blod",
                Description = "This is a asimple blog application build with ASP.NET MVC."
            });
        }
    }
}
