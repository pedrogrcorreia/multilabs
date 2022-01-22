using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultiLabs.Data;
using MultiLabs.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MultiLabs.Controllers
{
    [Authorize(Roles=("Admin, LabManager"))]
    public class TimeSlotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimeSlotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TimeSlots
        public async Task<IActionResult> Index(int? LaboratoryId)
        {
            int userId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userRole = User.FindFirstValue(ClaimTypes.Role);

            var applicationDbContext = _context.TimeSlots.Include(t => t.Laboratory).AsQueryable();

            if (userRole == "LabManager") {
                applicationDbContext = applicationDbContext.Where(l => l.Laboratory.UserId == userId);
                if (LaboratoryId != null) {
                    applicationDbContext = applicationDbContext.Where(l => l.LaboratoryId == LaboratoryId);
                }
            } else {
                if (LaboratoryId != null) {
                    applicationDbContext = applicationDbContext.Where(l => l.LaboratoryId == LaboratoryId);
                }
            }
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TimeSlots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeSlots = await _context.TimeSlots
                .Include(t => t.Laboratory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timeSlots == null)
            {
                return NotFound();
            }

            return View(timeSlots);
        }

        // GET: TimeSlots/Create
        public IActionResult Create(int? LaboratoryId)
        {
            int userId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (LaboratoryId != null) {
                ViewData["LaboratoryId"] = new SelectList(_context.Laboratories.Where(l => l.UserId == userId && l.Id == LaboratoryId), "Id", "Name");
            } else {
                ViewData["LaboratoryId"] = new SelectList(_context.Laboratories.Where(l => l.UserId == userId), "Id", "Name");
            }
            ViewBag.LabId = LaboratoryId;
            return View();
        }

        // POST: TimeSlots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTime,AvailableSlots,LaboratoryId")] TimeSlots timeSlots)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeSlots);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", timeSlots.LaboratoryId);
            return View(timeSlots);
        }

        // GET: TimeSlots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeSlots = await _context.TimeSlots.FindAsync(id);
            if (timeSlots == null)
            {
                return NotFound();
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", timeSlots.LaboratoryId);
            return View(timeSlots);
        }

        // POST: TimeSlots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTime,AvailableSlots,LaboratoryId")] TimeSlots timeSlots)
        {
            if (id != timeSlots.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeSlots);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeSlotsExists(timeSlots.Id))
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
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", timeSlots.LaboratoryId);
            return View(timeSlots);
        }

        // GET: TimeSlots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeSlots = await _context.TimeSlots
                .Include(t => t.Laboratory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timeSlots == null)
            {
                return NotFound();
            }

            return View(timeSlots);
        }

        // POST: TimeSlots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeSlots = await _context.TimeSlots.FindAsync(id);
            _context.TimeSlots.Remove(timeSlots);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeSlotsExists(int id)
        {
            return _context.TimeSlots.Any(e => e.Id == id);
        }
    }
}
