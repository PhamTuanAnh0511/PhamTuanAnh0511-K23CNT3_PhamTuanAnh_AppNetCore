using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamTuanAnh_2310900003.Models;

namespace PhamTuanAnh_2310900003.Controllers
{
    public class PtaEmployeesController : Controller
    {
        private readonly Phamtuananh2310900003Context _context;

        public PtaEmployeesController(Phamtuananh2310900003Context context)
        {
            _context = context;
        }

        // GET: PtaEmployees
        public async Task<IActionResult> PtaIndex()
        {
            return View(await _context.PtaEmployees.ToListAsync());
        }

        // GET: PtaEmployees/Details/5
        public async Task<IActionResult> PtaDetails(int? id)
        {
            if (id == null)
                return NotFound();

            var ptaEmployee = await _context.PtaEmployees
                .FirstOrDefaultAsync(m => m.PtaEmpId == id);
            if (ptaEmployee == null)
                return NotFound();

            return View(ptaEmployee);
        }

        // GET: PtaEmployees/Create
        public IActionResult PtaCreate()
        {
            return View();
        }

        // POST: PtaEmployees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PtaCreate([Bind("PtaEmpId,PtaEmpName,PtaEmpLevel,PtaEmpStartDate,PtaEmpStatus")] PtaEmployee ptaEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ptaEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PtaIndex));
            }
            return View(ptaEmployee);
        }

        // GET: PtaEmployees/Edit/5
        public async Task<IActionResult> PtaEdit(int? id)
        {
            if (id == null)
                return NotFound();

            var ptaEmployee = await _context.PtaEmployees.FindAsync(id);
            if (ptaEmployee == null)
                return NotFound();

            return View(ptaEmployee);
        }

        // POST: PtaEmployees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PtaEdit(int id, [Bind("PtaEmpId,PtaEmpName,PtaEmpLevel,PtaEmpStartDate,PtaEmpStatus")] PtaEmployee ptaEmployee)
        {
            if (id != ptaEmployee.PtaEmpId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ptaEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PtaEmployeeExists(ptaEmployee.PtaEmpId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(PtaIndex));
            }
            return View(ptaEmployee);
        }

        // GET: PtaEmployees/Delete/5
        public async Task<IActionResult> PtaDelete(int? id)
        {
            if (id == null)
                return NotFound();

            var ptaEmployee = await _context.PtaEmployees
                .FirstOrDefaultAsync(m => m.PtaEmpId == id);
            if (ptaEmployee == null)
                return NotFound();

            return View(ptaEmployee);
        }

        // POST: PtaEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ptaEmployee = await _context.PtaEmployees.FindAsync(id);
            if (ptaEmployee != null)
            {
                _context.PtaEmployees.Remove(ptaEmployee);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(PtaIndex));
        }

        private bool PtaEmployeeExists(int id)
        {
            return _context.PtaEmployees.Any(e => e.PtaEmpId == id);
        }
    }
}
