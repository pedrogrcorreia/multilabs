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
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace MultiLabs.Controllers {
    [Authorize(Roles=("Admin"))]
    public class StatsController : Controller {

        private readonly ApplicationDbContext _context;

        public StatsController(ApplicationDbContext context) {
            _context = context;
        }
        // GET: StatsController
        public async Task<IActionResult> Index(string? filter) {

            List<Stats> stats = new List<Stats>();

            var schedules = _context.Schedules
                .Include(l => l.Laboratory)
                .Include(l => l.Test)
                .Include(l => l.Result);

            if (filter != null) {
                if (filter == "Dia") {
                    var grouped = schedules.AsEnumerable().GroupBy(l => new { l.DateTime.Year, l.DateTime.Month, l.DateTime.Day });
                    foreach (var day in grouped) {
                        var date = day.Select(l => l.DateTime);
                        var total = day.Count();
                        var debug = day.Key;
                        var positive = day.Where(l => l.Result.Name == "Positivo").Count();
                        var negative = day.Where(l => l.Result.Name == "Negativo").Count();
                        var inconclusive = day.Where(l => l.Result.Name == "Inconclusivo").Count();
                        stats.Add(new Stats(total, positive, negative, inconclusive, new DateTime(debug.Year, debug.Month, debug.Day)));
                    }
                }
                if(filter == "Mes") {
                    var MonthGroup = schedules.AsEnumerable().GroupBy(l => new { l.DateTime.Year, l.DateTime.Month });
                    foreach (var day in MonthGroup) {
                        var date = day.Select(l => l.DateTime);
                        var total = day.Count();
                        var debug = day.Key;
                        var positive = day.Where(l => l.Result.Name == "Positivo").Count();
                        var negative = day.Where(l => l.Result.Name == "Negativo").Count();
                        var inconclusive = day.Where(l => l.Result.Name == "Inconclusivo").Count();
                        stats.Add(new Stats(total, positive, negative, inconclusive, new DateTime(debug.Year, debug.Month, DateTime.Now.Day)));
                    }
                }
                if (filter == "Semana") {

                    Func<DateTime, int> weekProjector =
                            d => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                 d,
                                 CalendarWeekRule.FirstFourDayWeek,
                                 DayOfWeek.Sunday);

                    var WeekGrouped = schedules.AsEnumerable().GroupBy(l => weekProjector(l.DateTime));
                    foreach (var day in WeekGrouped) {
                        var date = day.Select(l => l.DateTime).LastOrDefault();
                        var sunday = date.AddDays(-(int)date.DayOfWeek);
                        var total = day.Count();
                        var debug = day.Key;
                        var positive = day.Where(l => l.Result.Name == "Positivo").Count();
                        var negative = day.Where(l => l.Result.Name == "Negativo").Count();
                        var inconclusive = day.Where(l => l.Result.Name == "Inconclusivo").Count();
                        stats.Add(new Stats(total, positive, negative, inconclusive, sunday));
                    }
                }
            }

            ViewBag.Filter = filter;
            IEnumerable<Stats> ret = stats.AsEnumerable();
            return View(ret);
        }
    }
}
