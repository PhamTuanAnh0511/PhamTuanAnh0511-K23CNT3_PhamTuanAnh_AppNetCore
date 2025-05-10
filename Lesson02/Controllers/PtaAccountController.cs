using Microsoft.AspNetCore.Mvc;
using Lesson02.Models;

namespace Lesson02.Controllers
{
    public class PtaAccountController : Controller
    {
      
        private List<PtaAccount> GetAccounts()
        {
            return new List<PtaAccount>
            {
                new PtaAccount
                {
                    Id = 1,
                    Name = "Phạm Tuấn Anh",
                    Email = "Sktkgame69@gmail.com",
                    Phone = "0329930596",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/Avt1.jpg"),
                    Gender = 1,
                    Bio = "My name is Tuan",
                    Birthday = new DateTime(2005, 11, 05)
                },
                new PtaAccount
                {
                    Id = 2,
                    Name = "Trọng Hưng",
                    Email = "TrongHung@example.com",
                    Phone = "0329930000",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/Avt2.jpg"),
                    Gender = 1,
                    Bio = "My name is Hung",
                    Birthday = new DateTime(2005, 4, 2)
                },
                new PtaAccount
                {
                    Id = 3,
                    Name = "Lung Linh",
                    Email = "lunglinh@example.com",
                    Phone = "0329939999",
                    Address = "Ha Noi",
                    Avatar = Url.Content("~/Avatar/Avt3.jpg"),
                    Gender = 1,
                    Bio = "My name is Linh",
                    Birthday = new DateTime(2005, 3, 2)
                }
            };
        }

       
        public IActionResult PtaIndex()
        {
            ViewBag.Accounts = GetAccounts();
            return View();
        }
        [Route("ho-so-cua-toi")]
        public IActionResult PtaProfile(int id = 1) 
        {
            var account = GetAccounts().FirstOrDefault(a => a.Id == id);
            if (account == null) return NotFound();

            return View(account);
        }

    }
}


