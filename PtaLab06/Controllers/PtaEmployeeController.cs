using Microsoft.AspNetCore.Mvc;
using PtaLab06.Models;

namespace PtaLab06.Controllers
{
    public class PtaEmployeeController : Controller
    {
        public static List<PtaEmployee> ptaListEmployee = new List<PtaEmployee>
        {
            new PtaEmployee { PtaId = 1, PtaName = "Phạm Tuấn Anh", PtaBirthDay = new DateTime(2005,11,5), PtaEmail = "PTA051105@email.com", PtaPhone = "0123456789", PtaSalary = 1000, PtaStatus = true },
            new PtaEmployee { PtaId = 2, PtaName = "Trần Thị B", PtaBirthDay = new DateTime(1999,5,12), PtaEmail = "pta2@example.com", PtaPhone = "0987654321", PtaSalary = 2000, PtaStatus = false },
            new PtaEmployee { PtaId = 3, PtaName = "Lê Văn C", PtaBirthDay = new DateTime(1995,3,18), PtaEmail = "pta3@example.com", PtaPhone = "0911223344", PtaSalary = 1500, PtaStatus = true },
            new PtaEmployee { PtaId = 4, PtaName = "Đặng Thị D", PtaBirthDay = new DateTime(1993,8,30), PtaEmail = "pta4@example.com", PtaPhone = "0977332211", PtaSalary = 1700, PtaStatus = false },
            new PtaEmployee { PtaId = 5, PtaName = "Phạm Sinh Viên", PtaBirthDay = new DateTime(2001,6,15), PtaEmail = "pta_sinhvien@example.com", PtaPhone = "0999888777", PtaSalary = 1200, PtaStatus = true }
        };
        public IActionResult PtaIndex()
        {
            return View(ptaListEmployee);
        }

        public IActionResult PtaCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PtaCreateSubmit(PtaEmployee emp)
        {
            
            int maxId = 0;
            if (ptaListEmployee.Any())
            {
                maxId = ptaListEmployee.Select(e => e.PtaId).Max();
            }
            emp.PtaId = maxId + 1;

            ptaListEmployee.Add(emp);

            return RedirectToAction("PtaIndex");
        }

        public IActionResult PtaEdit(int id)
        {
            var emp = ptaListEmployee.FirstOrDefault(e => e.PtaId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PtaEdit(PtaEmployee updatedEmp)
        {
            if (!ModelState.IsValid)
            {
                return View(updatedEmp);
            }

            var emp = ptaListEmployee.FirstOrDefault(e => e.PtaId == updatedEmp.PtaId);
            if (emp == null)
            {
                return NotFound();
            }

            emp.PtaName = updatedEmp.PtaName;
            emp.PtaBirthDay = updatedEmp.PtaBirthDay;
            emp.PtaEmail = updatedEmp.PtaEmail;
            emp.PtaPhone = updatedEmp.PtaPhone;
            emp.PtaSalary = updatedEmp.PtaSalary;
            emp.PtaStatus = updatedEmp.PtaStatus;

            return RedirectToAction("PtaIndex");
        }

        public IActionResult PtaDelete(int id)
        {
            var emp = ptaListEmployee.FirstOrDefault(e => e.PtaId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost, ActionName("PtaDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult PtaDeleteConfirmed(int id)
        {
            var emp = ptaListEmployee.FirstOrDefault(e => e.PtaId == id);
            if (emp != null)
            {
                ptaListEmployee.Remove(emp);
            }
            return RedirectToAction("PtaIndex");
        }



    }
}
