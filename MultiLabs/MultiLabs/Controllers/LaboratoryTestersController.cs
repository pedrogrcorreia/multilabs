using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MultiLabs.Data;
using MultiLabs.Models;
using MultiLabs.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace MultiLabs.Controllers
{
    public class LaboratoryTestersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public LaboratoryTestersController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
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

        [HttpGet]
        public async Task<IActionResult> Register(int? id)
        {
            return View();
        }

        [HttpPost, ActionName("Register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register()
        {
            //TODO deixar o manager criar o tester com o mail que desejar
            // fazer isso na vista ou seja adicionar um campo para ele meter o 
            // email
            var id = _context.Users.OrderBy(l => l.Id).LastAsync().Id + 1;

            var user = new User { UserName = new string("tester" + id + "@gmail.com"), Email = new string("manager" + id + "@gmail.com") };
            var result = await _userManager.CreateAsync(user, "123Vv#");
            if (result.Succeeded)
            {
                int roleId = 3;
                var role = Roles.RolesUtils.All;//RegistSelectList.FirstOrDefault(s => s.Value == roleId.ToString());
                await (_userManager.AddToRoleAsync(user, "LabTester"));
                ViewBag.Success = "Tester with email " + "tester" + id + "@gmail.com" + " created successfully!";
            }
            return View();
        }


        private bool LaboratoryTestersExists(int id)
        {
            return _context.LaboratoryTesters.Any(e => e.LaboratoryId == id);
        }
    }
}
