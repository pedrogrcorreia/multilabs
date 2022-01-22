using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiLabs.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MultiLabs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MultiLabs.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context) {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string local) {
            var laboratories = _context.LaboratoryTests.Include(l => l.Laboratory).Include(l => l.Laboratory.Local).Include(l => l.Test).AsQueryable();

            if (!string.IsNullOrEmpty(local)) {
                laboratories = laboratories.Where(l => l.Laboratory.Local.Name == local);
            }

            var locals = _context.Locals.OrderBy(l => l.Name).Select(l => l.Name);

            ViewBag.Locals = locals.Select(c => new SelectListItem() { Text = c, Value = c }).Distinct().ToList();

            return View(await laboratories.ToListAsync());
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
