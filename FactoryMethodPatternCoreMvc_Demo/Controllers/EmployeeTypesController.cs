using FactoryMethodPatternCoreMvc_Demo.Data;
using FactoryMethodPatternCoreMvc_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethodPatternCoreMvc_Demo.Controllers
{
    public class EmployeeTypesController : Controller
    {
        private readonly ApplicationDbContext db;

        public EmployeeTypesController(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.EmployeeTypes.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeType = await db.EmployeeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeType == null)
            {
                return NotFound();
            }

            return View(employeeType);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeType employeeType)
        {
            if (ModelState.IsValid)
            {
                db.Add(employeeType);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeType);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeType = await db.EmployeeTypes.FindAsync(id);
            if (employeeType == null)
            {
                return NotFound();
            }
            return View(employeeType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EmployeeType employeeType)
        {
            if (id != employeeType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(employeeType);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeTypeExists(employeeType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employeeType);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeType = await db.EmployeeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeType == null)
            {
                return NotFound();
            }

            return View(employeeType);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeType = await db.EmployeeTypes.FindAsync(id);
            db.EmployeeTypes.Remove(employeeType);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeTypeExists(int id)
        {
            return db.EmployeeTypes.Any(e => e.Id == id);
        }
    }
}
