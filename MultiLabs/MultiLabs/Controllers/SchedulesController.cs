using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultiLabs.Data;
using MultiLabs.Models;
using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;

namespace MultiLabs.Controllers {
    [Authorize(Roles = "Client, LabTester")]
    public class SchedulesController : Controller {
        private readonly ApplicationDbContext _context;

        public SchedulesController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Schedules
        public async Task<IActionResult> Index() {
            int userId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var applicationDbContext = _context.Schedules.Include(s => s.Laboratory).Include(s => s.Test);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Schedules/Create
        public IActionResult Create(int? LaboratoryId) {
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories.Where(l => l.Id == LaboratoryId), "Id", "Name");
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Name");
            ViewData["DateTime"] = new SelectList(_context.TimeSlots.Where(l => l.AvailableSlots > 0 && l.LaboratoryId == LaboratoryId), "DateTime", "DateTime");
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TestId,LaboratoryId, DateTime")] Schedule schedule) {
            schedule.ClientId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (ModelState.IsValid) {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", schedule.LaboratoryId);
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Name", schedule.TestId);
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .Include(s => s.Laboratory)
                .Include(s => s.Test)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null) {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var schedule = await _context.Schedules.FindAsync(id);
            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id) {
            return _context.Schedules.Any(e => e.Id == id);
        }
    }
}
