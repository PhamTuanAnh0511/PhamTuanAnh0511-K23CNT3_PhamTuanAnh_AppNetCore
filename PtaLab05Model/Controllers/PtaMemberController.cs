using Microsoft.AspNetCore.Mvc;
using PtaLab05Model.Models.DataModels;
using PtaLab05Model.Models.DataModels;

namespace PtaLesson5.Controllers
{
    public class PtaMemberController : Controller
    {
        // Danh sách thành viên mẫu
        private static List<PtaMember> PtaMemberList = new List<PtaMember>
        {
            new PtaMember
            {
                PtaMemberID = Guid.NewGuid().ToString(),
                PtaUsername = "001",
                PtaFullname = "Phạm Tuấn Anh",
                PtaPassword = "051105",
                PtaEmail = "Pta051105@gmail.com"
            },
            new PtaMember
            {
                PtaMemberID = Guid.NewGuid().ToString(),
                PtaUsername = "002",
                PtaFullname = "Tran Thi B",
                PtaPassword = "pass02",
                PtaEmail = "user02@example.com"
            },
            new PtaMember
            {
                PtaMemberID = Guid.NewGuid().ToString(),
                PtaUsername = "003",
                PtaFullname = "Le Van C",
                PtaPassword = "pass03",
                PtaEmail = "user03@example.com"
            },
            new PtaMember
            {
                PtaMemberID = Guid.NewGuid().ToString(),
                PtaUsername = "004",
                PtaFullname = "Pham Thi D",
                PtaPassword = "pass04",
                PtaEmail = "user04@example.com"
            },
            new PtaMember
            {
                PtaMemberID = Guid.NewGuid().ToString(),
                PtaUsername = "005",
                PtaFullname = "Hoang Van E",
                PtaPassword = "pass05",
                PtaEmail = "user05@example.com"
            }
        };

        // Trang hiển thị danh sách thành viên
        public IActionResult PtaIndex()
        {
            return View(PtaMemberList); // truyền danh sách sang View
        }
    }
}