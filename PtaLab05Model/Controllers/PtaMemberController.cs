using Microsoft.AspNetCore.Mvc;
using PtaLab05Model.Models.DataModels;
using System;
using System.Collections.Generic;

namespace PtaLab05Model.Controllers
{
    public class PtaMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PtaGetMember()
        {
            // Tạo thông tin sinh viên
            var sinhVien = new PtaMember
            {
                PtaMemberId = Guid.NewGuid().ToString(),
                PtaUserName = "Anh",
                PtaFullName = "Phạm Tuấn Anh",
                PtaPassword = "123456",
                PtaEmail = "Pta0511@gmail.com"
            };

            // Tạo danh sách 5 thành viên, trong đó có sinh viên ở trên
            var members = new List<PtaMember>
            {
                sinhVien,
                new PtaMember
                {
                    PtaMemberId = Guid.NewGuid().ToString(),
                    PtaUserName = "001",
                    PtaFullName = "Phạm Tuấn Anh",
                    PtaPassword = "051105",
                    PtaEmail = "Pta051105@gmail.com"
                },
                new PtaMember
                {
                    PtaMemberId = Guid.NewGuid().ToString(),
                    PtaUserName = "002",
                    PtaFullName = "Tran Thi B",
                    PtaPassword = "pass02",
                    PtaEmail = "user02@example.com"
                },
                new PtaMember
                {
                    PtaMemberId = Guid.NewGuid().ToString(),
                    PtaUserName = "003",
                    PtaFullName = "Le Van C",
                    PtaPassword = "pass03",
                    PtaEmail = "user03@example.com"
                },
                new PtaMember
                {
                    PtaMemberId = Guid.NewGuid().ToString(),
                    PtaUserName = "004",
                    PtaFullName = "Pham Thi D",
                    PtaPassword = "pass04",
                    PtaEmail = "user04@example.com"
                }
            };

            // Truyền danh sách ra view
            ViewBag.PtaMember = sinhVien;
            return View(members);
        }
    }
}
