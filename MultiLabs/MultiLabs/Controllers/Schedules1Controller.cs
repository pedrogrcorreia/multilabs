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
    public class Schedules1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Schedules1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schedules1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Schedules.Include(s => s.Laboratory).Include(s => s.Result).Include(s => s.Test);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Schedules1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .Include(s => s.Laboratory)
                .Include(s => s.Result)
                .Include(s => s.Test)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedules1/Create
        public IActionResult Create()
        {
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Id");
            ViewData["ResultId"] = new SelectList(_context.Results, "Id", "Id");
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Id");
            return View();
        }

        // POST: Schedules1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TestId,LaboratoryId,DateTime,ClientId,TesterId,ResultId")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Id", schedule.LaboratoryId);
            ViewData["ResultId"] = new SelectList(_context.Results, "Id", "Id", schedule.ResultId);
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Id", schedule.TestId);
            return View(schedule);
        }

        // GET: Schedules1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Id", schedule.LaboratoryId);
            ViewData["ResultId"] = new SelectList(_context.Results, "Id", "Id", schedule.ResultId);
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Id", schedule.TestId);
            return View(schedule);
        }

        // POST: Schedules1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TestId,LaboratoryId,DateTime,ClientId,TesterId,ResultId")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
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
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Id", schedule.LaboratoryId);
            ViewData["ResultId"] = new SelectList(_context.Results, "Id", "Id", schedule.ResultId);
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Id", schedule.TestId);
            return View(schedule);
        }

        // GET: Schedules1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .Include(s => s.Laboratory)
                .Include(s => s.Result)
                .Include(s => s.Test)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedules.FindAsync(id);
            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedules.Any(e => e.Id == id);
        }
    }
}
