using Microsoft.AspNetCore.Mvc;
using PtaLab05Model.Models;
using System.Diagnostics;
using PtaLab05Model.Models;
using PtaLab05Model.Models;

namespace PtaLab05Model.Controllers
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

        public IActionResult PtaPrivacy()
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