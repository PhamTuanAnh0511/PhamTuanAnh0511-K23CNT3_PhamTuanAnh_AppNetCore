using Microsoft.AspNetCore.Mvc;
using PtaLesson04.Models;

namespace PtaLesson04.Controllers
{
    public class PtaBookController : Controller
    {
        private List<PtaBook> ptabooks = new List<PtaBook>
            {
                new PtaBook
                {
                    PtaId = "B001",
                    PtaTitle = "C# Programming Basics",
                    PtaDescription = "An introductory guide to C# programming.",
                    PtaImage = "book-1.jpg",
                    PtaPrice = 29.99f,
                    PtaPage = 320
                },
                new PtaBook
                {
                    PtaId = "B002",
                    PtaTitle = "ASP.NET Core in Action",
                    PtaDescription = "Learn how to build web apps with ASP.NET Core.",
                    PtaImage = "book-2.jpg",
                    PtaPrice = 39.99f,
                    PtaPage = 450
                },
                new PtaBook
                {
                    PtaId = "B003",
                    PtaTitle = "Mastering LINQ",
                    PtaDescription = "Advanced techniques with LINQ for data manipulation.",
                    PtaImage = "book-3.jpg",
                    PtaPrice = 34.95f,
                    PtaPage = 280
                },
                new PtaBook
                {
                    PtaId = "B004",
                    PtaTitle = "Entity Framework Core Guide",
                    PtaDescription = "Complete guide to EF Core with examples.",
                    PtaImage = "book-4.jpg",
                    PtaPrice = 42.50f,
                    PtaPage = 390
                },
                new PtaBook
                {
                    PtaId = "B005",
                    PtaTitle = "Clean Code with C#",
                    PtaDescription = "Best practices for writing clean, maintainable code in C#.",
                    PtaImage = "book-5.jpg",
                    PtaPrice = 37.00f,
                    PtaPage = 360
                }
        };

        public IActionResult PtaIndex()
        {
            return View(ptabooks);
        }
        public IActionResult PtaCreate()
        {
            PtaBook ptaBook =new PtaBook();
            return View(ptaBook); 
        }
        public IActionResult PtaCreateSubbmit()
        {
            return RedirectToAction("PtaIndex");
        }
    }
}
