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
        public async Task<IActionResult> Index(int? LaboratoryId, string search) {

            // TODO ir buscar se é user ou tecnico e devolver os do laboratorio ou os dele

            string userRole = User.FindFirstValue(ClaimTypes.Role);
            int userId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var schedules = _context.Schedules.Include(s => s.Laboratory).Include(s => s.Test).Include(s => s.Result).AsQueryable();


            if (userRole == "LabTester") {
                var laboratoryTesters = _context.LaboratoryTesters.Where(l => l.UserId == userId);
                var laboratories = laboratoryTesters.Select(l => l.Laboratory);
                schedules = schedules.Where(l => laboratories.Contains(l.Laboratory));
                if (!string.IsNullOrEmpty(search)) {
                    schedules = schedules.Where(s => s.Tester.Id == userId); // seleciona só os do tecnico
                    schedules = schedules.Where(s => s.Client.UserName.Contains(search) ||
                                                        s.DateTime.ToString().Contains(search)); // dos que pertencem ao tecnico seleciona os que foram feitos pelo cliente
                }

                ViewBag.Search = search;

                if (LaboratoryId != null) {
                    //schedules = _context.Schedules.Include(s => s.Laboratory).Include(s => s.Test).Where(l => l.Laboratory.Id == LaboratoryId);
                    schedules = schedules.Where(l => l.Laboratory.Id == LaboratoryId); // se estiver a ver de um laboratorio, seleciona só os desse que pertencem ao técnico
                }
            } else {
                schedules = schedules.Where(s => s.Client.Id == userId);
            }

            return View(await schedules.ToListAsync());
        }

        [Authorize(Roles=("LabTester"))]
        public async Task<IActionResult> IndexTester(int? LaboratoryId) {
            int userId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var schedules = _context.Schedules.Include(s => s.Laboratory).Include(s => s.Test).Include(s => s.Result).AsQueryable();
            schedules = schedules.Where(s => s.Tester.Id == userId); // só os deste tecnico

            if (LaboratoryId != null) {
                schedules = schedules.Where(l => l.Laboratory.Id == LaboratoryId); // se estiver a ver de um laboratorio, seleciona só os desse que pertencem ao técnico
            }

            return View(await schedules.ToListAsync());
        }


        [Authorize(Roles=("Client"))]
        // GET: Schedules/Create
        public IActionResult Create(int? LaboratoryId) {
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories.Where(l => l.Id == LaboratoryId), "Id", "Name");
            ViewData["TestId"] = new SelectList(_context.LaboratoryTests.Where(l => l.Laboratory.Id == LaboratoryId).Select(l => new {l.Test.Id, l.Test.Name }), "Id", "Name");
            ViewData["DateTime"] = new SelectList(_context.TimeSlots.Where(l => l.AvailableSlots > 0 && l.LaboratoryId == LaboratoryId &&
                                        l.DateTime > DateTime.Now), "DateTime", "DateTime");
            return View();
        }

        [Authorize(Roles = ("Client"))]
        // POST: Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TestId,LaboratoryId, DateTime")] Schedule schedule) {
            schedule.ClientId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            schedule.TesterId = 1;
            if (ModelState.IsValid) {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", schedule.LaboratoryId);
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Name", schedule.TestId);
            return View(schedule);
        }

        [Authorize(Roles = ("Client"))]
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

        [Authorize(Roles = ("Client"))]
        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var schedule = await _context.Schedules.FindAsync(id);

            if((schedule.DateTime-DateTime.Now).TotalDays < 1) {
                ViewBag.Error = "Impossível cancelar este agendamento. Faltam menos de 24 horas.";
                schedule = await _context.Schedules
                .Include(s => s.Laboratory)
                .Include(s => s.Test)
                .FirstOrDefaultAsync(m => m.Id == id);
                return View(schedule);
            }
            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id) {
            return _context.Schedules.Any(e => e.Id == id);
        }

        [Authorize(Roles = ("LabTester"))]
        // GET: Schedules1/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }
            int userId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null) {
                return NotFound();
            } if(schedule.TesterId != userId) {
                ViewBag.Error = "Não tem acesso a este agendamento! Torne-se o técnico responsável!";
                return View();
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories.Where(l => l.Id == schedule.LaboratoryId), "Id", "Name", schedule.LaboratoryId);
            ViewData["ResultId"] = new SelectList(_context.Results, "Id", "Name", schedule.ResultId);
            ViewData["TestId"] = new SelectList(_context.Tests.Where(t => t.Id == schedule.TestId), "Id", "Name", schedule.TestId);
            return View(schedule);
        }

        [Authorize(Roles = ("LabTester"))]
        // POST: Schedules1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, /*[Bind("Id,TestId,LaboratoryId,DateTime,ClientId,TesterId,ResultId")] Schedule schedule*/ int ResultId) {

            var schedule = await _context.Schedules.FindAsync(id);

            if (id != schedule.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    schedule.ResultId = ResultId;
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!ScheduleExists(schedule.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LaboratoryId"] = new SelectList(_context.Laboratories, "Id", "Name", schedule.LaboratoryId);
            ViewData["ResultId"] = new SelectList(_context.Results, "Id", "Name", schedule.ResultId);
            ViewData["TestId"] = new SelectList(_context.Tests, "Id", "Name", schedule.TestId);
            return View(schedule);
        }

        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            if (Request.Headers["Referer"].ToString() != null) {
                ViewData["Reffer"] = Request.Headers["Referer"].ToString();
            }

            var schedule = await _context.Schedules
                .Include(s => s.Laboratory)
                .Include(s => s.Result)
                .Include(s => s.Test)
                .Include(s => s.Client)
                .Include(s => s.Tester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null) {
                return NotFound();
            }

            return View(schedule);
        }


        [Authorize(Roles = ("LabTester"))]
        public async Task<IActionResult> SelectSchedule(int? id) {
            if (id == null) {
                return NotFound();
            }

            var schedule = await _context.Schedules
                .Include(s => s.Laboratory)
                .Include(s => s.Result)
                .Include(s => s.Test)
                .Include(s => s.Client)
                .Include(s => s.Tester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null) {
                return NotFound();
            }

            return View(schedule);
        }


        [Authorize(Roles = ("LabTester"))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SelectSchedule(int id) {
            var schedule = await _context.Schedules.FindAsync(id);

            int userId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (id != schedule.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    schedule.TesterId = userId;
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!ScheduleExists(schedule.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(schedule);
        }
    }
}
