using Lesson02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Lesson02.Controllers
{
    public class PtaProductController : Controller
    {
        // ✅ Hiển thị danh sách mô tô
        public IActionResult PtaIndex()
        {
            var viewModel = new PtaMotoCategoryViewModel
            {
                Motos = GetAllMotos(),
                Categories = GetAllCategories()
            };
            return View(viewModel);
        }

        // ✅ Lọc theo danh mục
        public IActionResult FilterByCategory(int categoryId)
        {
            var filteredMotos = GetAllMotos().Where(m => m.CategoryId == categoryId).ToList();

            var viewModel = new PtaMotoCategoryViewModel
            {
                Motos = filteredMotos,
                Categories = GetAllCategories()
            };

            return View("PtaIndex", viewModel); // Dùng lại view PtaIndex
        }

        // ✅ Chi tiết mô tô
        public IActionResult PtaDetail(int id)
        {
            var motos = GetAllMotos();
            var selectedMoto = motos.FirstOrDefault(m => m.Id == id);

            if (selectedMoto == null)
            {
                return NotFound();  // Nếu không tìm thấy mô tô, trả về lỗi 404
            }

            var categories = GetAllCategories();  // Lấy danh sách danh mục

            var viewModel = new PtaMotoCategoryViewModel
            {
                Motos = new List<PtaMoto> { selectedMoto },
                Categories = categories  // Đảm bảo Categories không phải null
            };

            return View(viewModel);  // Trả về view chi tiết
        }

        // ✅ Phương thức dùng chung để lấy danh mục
        private List<PtaCategory> GetAllCategories()
        {
            return new List<PtaCategory>
            {
                new PtaCategory { Id = 1, Name = "Honda" },
                new PtaCategory { Id = 2, Name = "Yamaha" },
                new PtaCategory { Id = 3, Name = "Suzuki" },
                new PtaCategory { Id = 4, Name = "Kawasaki" },
                new PtaCategory { Id = 5, Name = "Ducati" },
                new PtaCategory { Id = 6, Name = "BMW" },
                new PtaCategory { Id = 7, Name = "Harley-Davidson" },
                new PtaCategory { Id = 8, Name = "KTM" },
                new PtaCategory { Id = 9, Name = "Piaggio" },
                new PtaCategory { Id = 10, Name = "Triumph" }
            };
        }

        // ✅ Phương thức dùng chung để lấy danh sách mô tô
        private List<PtaMoto> GetAllMotos()
        {
            return new List<PtaMoto>
            {
                new PtaMoto { Id = 1, Name = "Honda SH 150i", Avatar = "Avatar/Sh150i.jpg", Price = 110000000, SalePrice = 105000000, CategoryId = 1, Description = "Xe tay ga cao cấp", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 2, Name = "Yamaha Exciter 155", Avatar = "Avatar/ex150.jpg", Price = 50000000, SalePrice = 48000000, CategoryId = 2, Description = "Xe côn tay thể thao", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 3, Name = "Suzuki Raider R150", Avatar = "Avatar/raider.jpg", Price = 46000000, SalePrice = 44500000, CategoryId = 3, Description = "Xe thể thao nhỏ gọn", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 4, Name = "Kawasaki Ninja ZX-10R", Avatar = "Avatar/zx10r.jpg", Price = 400000000, SalePrice = 390000000, CategoryId = 4, Description = "Superbike mạnh mẽ", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 5, Name = "Ducati Panigale V4", Avatar = "Avatar/panigale.jpg", Price = 700000000, SalePrice = 680000000, CategoryId = 5, Description = "Siêu mô tô Ý", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 6, Name = "BMW S1000RR", Avatar = "Avatar/s1000rr.jpg", Price = 800000000, SalePrice = 780000000, CategoryId = 6, Description = "Mô tô thể thao Đức", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 7, Name = "Harley-Davidson Sportster S", Avatar = "Avatar/harley.jpg", Price = 500000000, SalePrice = 480000000, CategoryId = 7, Description = "Xe cruiser mạnh mẽ", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 8, Name = "KTM Duke 390", Avatar = "Avatar/duke390.jpg", Price = 150000000, SalePrice = 145000000, CategoryId = 8, Description = "Xe naked bike phong cách", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 9, Name = "Piaggio Liberty", Avatar = "Avatar/liberty.jpg", Price = 60000000, SalePrice = 58000000, CategoryId = 9, Description = "Xe tay ga phong cách Ý", Status = true, CreatedAt = DateTime.Now },
                new PtaMoto { Id = 10, Name = "Triumph Street Triple", Avatar = "Avatar/triple.jpg", Price = 350000000, SalePrice = 330000000, CategoryId = 10, Description = "Naked bike Anh quốc", Status = true, CreatedAt = DateTime.Now }
            };
        }
    }
}
