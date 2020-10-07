using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IHome.Models;

namespace IHome.Controllers
{
    public class SchedulersController : Controller
    {
        private readonly EFCContext _context;

        public SchedulersController(EFCContext context)
        {
            _context = context;
        }

        // GET: Schedulers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Scheduler.ToListAsync());
        }

        // GET: Schedulers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduler = await _context.Scheduler
                .FirstOrDefaultAsync(m => m.ID == id);
            if (scheduler == null)
            {
                return NotFound();
            }

            return View(scheduler);
        }

        // GET: Schedulers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schedulers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,StartTime,EndTime,At,For")] Scheduler scheduler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheduler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheduler);
        }

        // GET: Schedulers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduler = await _context.Scheduler.FindAsync(id);
            if (scheduler == null)
            {
                return NotFound();
            }
            return View(scheduler);
        }

        // POST: Schedulers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,StartTime,EndTime,At,For")] Scheduler scheduler)
        {
            if (id != scheduler.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheduler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchedulerExists(scheduler.ID))
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
            return View(scheduler);
        }

        // GET: Schedulers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scheduler = await _context.Scheduler
                .FirstOrDefaultAsync(m => m.ID == id);
            if (scheduler == null)
            {
                return NotFound();
            }

            return View(scheduler);
        }

        // POST: Schedulers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scheduler = await _context.Scheduler.FindAsync(id);
            _context.Scheduler.Remove(scheduler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchedulerExists(int id)
        {
            return _context.Scheduler.Any(e => e.ID == id);
        }
    }
}
