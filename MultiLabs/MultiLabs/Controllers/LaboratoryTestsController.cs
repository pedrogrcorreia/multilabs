using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultiLabs.Data;
using MultiLabs.Models;

namespace MultiLabs.Controllers
{
    public class LaboratoryTestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LaboratoryTestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LaboratoryTests
        public async Task<IActionResult> Index(int? LaboratoryId) {
            IQueryable<LaboratoryTest> applicationDbContext;
            if (LaboratoryId == null) {
                applicationDbContext = _context.LaboratoryTests.Include(l => l.Laboratory).Include(l => l.Test);
            }

            applicationDbContext = _context.LaboratoryTests.Include(l => l.Laboratory).Include(l => l.Test).Where(l => l.LaboratoryId == LaboratoryId);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LaboratoryTests/Create
        public IActionResult Create()
        {
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name");
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Name");
            return View();
        }

        // POST: LaboratoryTests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaboratoryId,TestId")] LaboratoryTest laboratoryTest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laboratoryTest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", laboratoryTest.LaboratoryId);
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Name", laboratoryTest.TestId);
            return View(laboratoryTest);
        }

        // GET: LaboratoryTests/Delete/5
        public async Task<IActionResult> Delete(int? LaboratoryId, int? TestId)
        {
            if (LaboratoryId == null || TestId == null)
            {
                return NotFound();
            }

            var laboratoryTest = await _context.LaboratoryTests
                .Include(l => l.Laboratory)
                .Include(l => l.Test)
                .FirstOrDefaultAsync(m => m.LaboratoryId == LaboratoryId && m.TestId == TestId);
            if (laboratoryTest == null)
            {
                return NotFound();
            }

            return View(laboratoryTest);
        }

        // POST: LaboratoryTests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? LaboratoryId, int? TestId)
        {
            var laboratoryTest = await _context.LaboratoryTests.FindAsync(LaboratoryId, TestId);
            _context.LaboratoryTests.Remove(laboratoryTest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratoryTestExists(int LaboratoryId, int TestId)
        {
            return _context.LaboratoryTests.Any(e => e.LaboratoryId == LaboratoryId && e.TestId == TestId);
        }
    }
}
