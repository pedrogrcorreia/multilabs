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
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MultiLabs.Controllers
{
    [Authorize(Roles = ("Admin, LabManager"))]
    public class LaboratoryTestersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public LaboratoryTestersController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: LaboratoryTesters
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LaboratoryTesters.Include(l => l.Laboratory).Include(l => l.User).AsQueryable();

            var userid = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userRole = User.FindFirstValue(ClaimTypes.Role);
            if (userRole == "LabManager") {
                applicationDbContext = applicationDbContext.Where(l => l.Laboratory.User.Id == userid);
            }
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LaboratoryTesters/Details/5
        public async Task<IActionResult> Details(int? LaboratoryId, int? UserId)
        {
            if (LaboratoryId == null || UserId == null)
            {
                return NotFound();
            }

            var laboratoryTesters = await _context.LaboratoryTesters
                .Include(l => l.Laboratory)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.LaboratoryId == LaboratoryId && m.UserId == UserId);
            if (laboratoryTesters == null)
            {
                return NotFound();
            }

            return View(laboratoryTesters);
        }

        // GET: LaboratoryTesters/Create
        public IActionResult Create()
        {
            var userid = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userRole = User.FindFirstValue(ClaimTypes.Role);
            var users = _context.UserRoles.Where(u => u.RoleId == 3).Select(u => u.UserId).ToList();
            if (userRole == "LabManager") {
                ViewData["LaboratoryId"] = new SelectList(_context.Laboratories.Where(l => l.UserId == userid), "Id", "Name");
            } else {
                ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name");
            }
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
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", laboratoryTesters.LaboratoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", laboratoryTesters.UserId);
            return View(laboratoryTesters);
        }

        // GET: LaboratoryTesters/Edit/5
        public async Task<IActionResult> Edit(int? LaboratoryId, int? UserId)
        {
            if (LaboratoryId == null || UserId == null)
            {
                return NotFound();
            }

            var laboratoryTesters = await _context.LaboratoryTesters.FindAsync(LaboratoryId, UserId);
            if (laboratoryTesters == null)
            {
                return NotFound();
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", laboratoryTesters.LaboratoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", laboratoryTesters.UserId);
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
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", laboratoryTesters.LaboratoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", laboratoryTesters.UserId);
            return View(laboratoryTesters);
        }

        // GET: LaboratoryTesters/Delete/5
        public async Task<IActionResult> Delete(int? LaboratoryId, int? UserId)
        {
            if (LaboratoryId == null || UserId == null)
            {
                return NotFound();
            }

            var laboratoryTesters = await _context.LaboratoryTesters
                .Include(l => l.Laboratory)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.LaboratoryId == LaboratoryId && m.UserId == UserId);
            if (laboratoryTesters == null)
            {
                return NotFound();
            }

            return View(laboratoryTesters);
        }

        // POST: LaboratoryTesters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int LaboratoryId, int UserId)
        {
            var laboratoryTesters = await _context.LaboratoryTesters.FindAsync(LaboratoryId, UserId);
            _context.LaboratoryTesters.Remove(laboratoryTesters);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Register() { 
            return View();
        }

        [HttpPost, ActionName("Register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel.InputModel input)
        {
            var email = input.Email;
            var password = input.Password;
            //TODO deixar o manager criar o tester com o mail que desejar
            // fazer isso na vista ou seja adicionar um campo para ele meter o 
            // email
            var id = _context.Users.OrderBy(l => l.Id).LastAsync().Id + 1;

            var user = new User { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                var role = Roles.RolesUtils.All;//RegistSelectList.FirstOrDefault(s => s.Value == roleId.ToString());
                await (_userManager.AddToRoleAsync(user, "LabTester"));
                ViewBag.Success = "Tester with email " + email + " created successfully!";
            }
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            result = await _userManager.ConfirmEmailAsync(user, code);
            return View();
        }


        private bool LaboratoryTestersExists(int id)
        {
            return _context.LaboratoryTesters.Any(e => e.LaboratoryId == id);
        }
    }
}
