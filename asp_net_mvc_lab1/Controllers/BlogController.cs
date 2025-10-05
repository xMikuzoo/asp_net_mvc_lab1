using asp_net_mvc_lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_lab1.Controllers
{
    public class BlogController(ILogger<BlogController> logger) : Controller
    {
        private static readonly List<BlogArticleViewModel> articles = new()
        {
            new BlogArticleViewModel
            {
                Title = "First Article",
                Description = "This is the description of the first article."
            },
            new BlogArticleViewModel
            {
                Title = "Second Article",
                Description = "This is the description of the second article."
            },
            new BlogArticleViewModel
            {
                Title = "Third Article",
                Description = "This is the description of the third article."
            }
        };
        public IActionResult Index()
        {
            return View(articles);
        }
    }
}
