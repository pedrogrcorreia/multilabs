using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultiLabs.Data;
using MultiLabs.Models;
using Microsoft.AspNetCore.Authorization;

namespace MultiLabs.Controllers
{
    public class LaboratoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LaboratoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Laboratories
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //IQueryable<Laboratory> applicationDbContext;
            var userRole = User.FindFirstValue(ClaimTypes.Role);
            var userid = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var laboratories = _context.Laboratories.Include(l => l.Local).AsQueryable();

            if(userRole == "LabManager") {
                //applicationDbContext = _context.Laboratories.Include(l => l.Local).Where(l => l.UserId == userid); // Devolve apenas os labs que criou
                laboratories = laboratories.Where(l => l.UserId == userid);
            } else if(userRole == "Client") {
                //applicationDbContext = _context.Laboratories.Include(l => l.Local); // Devolve todos os laboratorios para o cliente
            } else if(userRole == "LabTester"){
                var testerLaboratories = _context.LaboratoryTesters.Include(l => l.Laboratory.Local).Where(l => l.UserId == userid).AsQueryable();
                laboratories = testerLaboratories.Select(l => l.Laboratory);
                //applicationDbContext = testerLaboratories.Select(l => l.Laboratory).Include(l => l.Local);
            }
            return View(await laboratories.ToListAsync());
        }

        // GET: Laboratories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratory = await _context.Laboratories
                .Include(l => l.Local)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laboratory == null)
            {
                return NotFound();
            }

            return View(laboratory);
        }

        // GET: Laboratories/Create
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> items = _context.Locals.Select(c => new SelectListItem {
                Value = c.Id.ToString(),
                Text = c.Name + " - " + c.Address
            });

            //ViewData["LocalId"] = new SelectList(_context.Locals, "Id", "Name");
            ViewData["LocalId"] = new SelectList(items, "Value", "Text");
            return View();
        }

        // POST: Laboratories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LocalId")] Laboratory laboratory)
        {
            laboratory.UserId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (ModelState.IsValid)
            {
                _context.Add(laboratory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocalId"] = new SelectList(_context.Locals, "Id", "Name", laboratory.LocalId);
            return View(laboratory);
        }

        // GET: Laboratories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laboratory = await _context.Laboratories
                .Include(l => l.Local)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laboratory == null)
            {
                return NotFound();
            }

            return View(laboratory);
        }

        // POST: Laboratories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laboratory = await _context.Laboratories.FindAsync(id);
            _context.Laboratories.Remove(laboratory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaboratoryExists(int id)
        {
            return _context.Laboratories.Any(e => e.Id == id);
        }
    }
}
