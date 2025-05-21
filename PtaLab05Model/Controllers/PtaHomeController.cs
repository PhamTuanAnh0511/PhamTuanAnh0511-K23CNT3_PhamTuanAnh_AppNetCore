using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using PtaLab05Model.Models;
using PtaLab05Model.Models.DataModels;



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
            PtaMember PtaMember = new PtaMember();

            PtaMember.PtaMemberID = Guid.NewGuid().ToString();
            PtaMember.PtaUsername = "Anh";
            PtaMember.PtaFullname = "Phạm Tuấn Anh";
            PtaMember.PtaPassword = "051105";
            PtaMember.PtaEmail = "Pta051105@gmail.com";

            ViewBag.member = PtaMember;
            return View(PtaMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}