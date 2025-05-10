using Lesson02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson02.Controllers
{
    public class PtaHomeController : Controller
    {
        private readonly ILogger<PtaHomeController> _logger;

        public PtaHomeController(ILogger<PtaHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PtaIndex()
        {
            return View();
        }

        public IActionResult PtaAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}