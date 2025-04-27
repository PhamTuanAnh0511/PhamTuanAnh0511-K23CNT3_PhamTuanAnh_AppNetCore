using Microsoft.AspNetCore.Mvc;

namespace Myapp1.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
