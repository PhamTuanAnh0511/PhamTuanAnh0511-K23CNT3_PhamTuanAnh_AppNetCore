using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Models
{
    public class PtaCategory : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; } // Ví dụ: "Xe côn tay", "Xe tay ga"
    }

}
