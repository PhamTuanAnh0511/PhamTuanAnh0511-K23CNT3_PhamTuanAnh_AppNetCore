using Microsoft.AspNetCore.Mvc;

namespace Myapp1.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
