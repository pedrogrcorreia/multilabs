using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultiLabs.Data;
using MultiLabs.Models;

namespace MultiLabs.Controllers
{
    public class LaboratoryTestersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LaboratoryTestersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LaboratoryTesters
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LaboratoryTesters.Include(l => l.Laboratory).Include(l => l.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LaboratoryTesters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTesters = await _context.LaboratoryTesters
                .Include(l => l.Laboratory)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.LaboratoryId == id);
            if (laboratoryTesters == null)
            {
                return NotFound();
            }

            return View(laboratoryTesters);
        }

        // GET: LaboratoryTesters/Create
        public IActionResult Create()
        {
            var users = _context.UserRoles.Where(u => u.RoleId == 3).Select(u => u.UserId).ToList();
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.Users.Where(u => users.Contains(u.Id)), "Id", "UserName");
            return View();
        }

        // POST: LaboratoryTesters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LaboratoryId,UserId")] LaboratoryTesters laboratoryTesters)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laboratoryTesters);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Id", laboratoryTesters.LaboratoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", laboratoryTesters.UserId);
            return View(laboratoryTesters);
        }

        // GET: LaboratoryTesters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTesters = await _context.LaboratoryTesters.FindAsync(id);
            if (laboratoryTesters == null)
            {
                return NotFound();
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Id", laboratoryTesters.LaboratoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", laboratoryTesters.UserId);
            return View(laboratoryTesters);
        }

        // POST: LaboratoryTesters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LaboratoryId,UserId")] LaboratoryTesters laboratoryTesters)
        {
            if (id != laboratoryTesters.LaboratoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laboratoryTesters);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaboratoryTestersExists(laboratoryTesters.LaboratoryId))
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
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Id", laboratoryTesters.LaboratoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", laboratoryTesters.UserId);
            return View(laboratoryTesters);
        }

        // GET: LaboratoryTesters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratoryTesters = await _context.LaboratoryTesters
                .Include(l => l.Laboratory)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.LaboratoryId == id);
            if (laboratoryTesters == null)
            {
                return NotFound();
            }

            return View(laboratoryTesters);
        }

        // POST: LaboratoryTesters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laboratoryTesters = await _context.LaboratoryTesters.FindAsync(id);
            _context.LaboratoryTesters.Remove(laboratoryTesters);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratoryTestersExists(int id)
        {
            return _context.LaboratoryTesters.Any(e => e.LaboratoryId == id);
        }
    }
}
