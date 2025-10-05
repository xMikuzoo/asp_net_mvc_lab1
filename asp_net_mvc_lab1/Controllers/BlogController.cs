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
                Id = "1",
                Title = "First Article",
                Description = "This is the description of the first article.",
                Content = "This is the content of the first article."
            },
            new BlogArticleViewModel
            {
                Id = "2",
                Title = "Second Article",
                Description = "This is the description of the second article.",
                Content = "This is the content of the second article."
            },
            new BlogArticleViewModel
            {
                Id = "3",
                Title = "Third Article",
                Description = "This is the description of the third article.",
                Content = "This is the content of the third article."
            }
        };

        public IActionResult Article(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) {
                return NotFound();
            };

            var post = articles.FirstOrDefault(x => x.Id.Equals(id,StringComparison.OrdinalIgnoreCase));

            if(post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        public IActionResult Index()
        {
            return View(articles);
        }
    }
}
