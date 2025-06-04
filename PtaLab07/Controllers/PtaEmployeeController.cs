using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PtaLab07.Models;

namespace PtaLab07.Controllers
{
    public class PtaEmployeeController : Controller
    {
        private static List<PtaEmployee> ptaListEmployees = new List<PtaEmployee>()
        {
            new PtaEmployee
            {
                PtaId = 2310900003,
                PtaName = "Phạm Tuấn Anh",
                PtaBirthDay = new DateTime(2005, 11, 05),
                PtaEmail = "PTA051105@email.com",
                PtaPhone = "0984551682",
                PtaSalary = 12000000,
                PtaStatus = true
            },
            new PtaEmployee
            {
                PtaId = 2,
                PtaName = "Tran Thi B",
                PtaBirthDay = new DateTime(1988, 8, 20),
                PtaEmail = "b.tran@example.com",
                PtaPhone = "0912345678",
                PtaSalary = 13000000,
                PtaStatus = true
            },
            new PtaEmployee
            {
                PtaId = 3,
                PtaName = "Le Van C",
                PtaBirthDay = new DateTime(1995, 2, 15),
                PtaEmail = "c.le@example.com",
                PtaPhone = "0923456789",
                PtaSalary = 11000000,
                PtaStatus = false
            },
            new PtaEmployee
            {
                PtaId = 4,
                PtaName = "Pham Thi D",
                PtaBirthDay = new DateTime(1992, 11, 5),
                PtaEmail = "d.pham@example.com",
                PtaPhone = "0934567890",
                PtaSalary = 14000000,
                PtaStatus = true
            },
            new PtaEmployee
            {
                PtaId = 5,
                PtaName = "Hoang Van E",
                PtaBirthDay = new DateTime(1993, 3, 25),
                PtaEmail = "e.hoang@example.com",
                PtaPhone = "0945678901",
                PtaSalary = 10000000,
                PtaStatus = false
            }
        };

        // GET: PtaEmployee
        public ActionResult PtaIndex()
        {
            return View(ptaListEmployees);
        }

        // GET: PtaEmployee/Details/5
        public ActionResult PtaDetails(int id)
        {

            var ptaEmployee = ptaListEmployees.FirstOrDefault(x => x.PtaId == id);
            return View(ptaEmployee);
        }

        // GET: PtaEmployee/Create
        public ActionResult PtaCreate()
        {
            var ptaEmployee = new PtaEmployee();
            return View();
        }

        // POST: PtaEmployee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaCreate(PtaEmployee ptaModel)
        {
            try
            {
                ptaModel.PtaId = ptaListEmployees.Max(x => x.PtaId) + 1;
                ptaListEmployees.Add(ptaModel);
                return RedirectToAction(nameof(PtaIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: PtaEmployee/Edit/5
        public ActionResult PtaEdit(int id)
        {
            var ptaEmployee = ptaListEmployees.FirstOrDefault(x => x.PtaId == id);
            return View(ptaEmployee);
        }

        // POST: PtaEmployee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaEdit(int id, PtaEmployee ptaModel)
        {
            try
            {
                for (int i = 0; i < ptaListEmployees.Count(); i++)
                {
                    if (ptaListEmployees[i].PtaId == id)
                    {
                        ptaListEmployees[i] = ptaModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(PtaIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: PtaEmployee/Delete/5
        // GET
        public ActionResult PtaDelete(long id)
        {
            var ptaEmployee = ptaListEmployees.FirstOrDefault(e => e.PtaId == id);
            if (ptaEmployee == null)
            {
                return NotFound();
            }

            return View(ptaEmployee);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PtaDelete(long id, PtaEmployee ptaModel)
        {
            try
            {
                var ptaEmployee = ptaListEmployees.FirstOrDefault(e => e.PtaId == id);
                if (ptaEmployee != null)
                {
                    ptaListEmployees.Remove(ptaEmployee);
                }

                return RedirectToAction(nameof(PtaIndex));
            }
            catch
            {
                return View();
            }
        }

    }
}
