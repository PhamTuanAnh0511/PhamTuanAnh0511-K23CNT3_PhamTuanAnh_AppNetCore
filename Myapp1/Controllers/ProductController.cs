using Microsoft.AspNetCore.Mvc;

namespace Myapp1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
