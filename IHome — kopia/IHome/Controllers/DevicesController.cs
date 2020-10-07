﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IHome.Models;
using System.Security.Cryptography.X509Certificates;

namespace IHome.Controllers
{
    public class DevicesController : Controller
    {
        private readonly EFCContext _context;

        public DevicesController(EFCContext context)
        {
            _context = context;
        }

        // GET: Devices
        public async Task<IActionResult> Index([FromServices] EFCContext context)
        {
            return View(await context.Devices.Include(id=>id.Buildings).ToListAsync());
        }

        // GET: Devices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = _context.Devices.Include(id => id.Buildings).Include(id => id.Zones).Include(id=>id.Groups).Single(x => x.ID == id);
                //.FirstOrDefaultAsync(m => m.ID == id);
            if (devices == null)
            {
                return NotFound();
            }

            return View(devices);
        }
        public IActionResult Create()
        {
            ViewData["BuildingList"] = _context.Buildings.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description")] Devices devices)
        {
            var selectedValue = int.Parse(Request.Form["BuildingList"]);

            devices.Building = ;
            //devices.Buildings =1;
            //devices.Buildings =1;
            if (ModelState.IsValid)
            {
                _context.Add(devices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devices);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //var row = Context.CustomerModels.Include(x => x.AddressModel).Single(x => x.ID == id);
            //var devices2 = _context.Devices.Include(x => x.Buildings).Single(x => x.ID == id);
            var devices = await _context.Devices.FindAsync(id);
            if (devices == null)
            {
                return NotFound();
            }
            ViewData["BuildingList"] = _context.Buildings.ToList();
            return View(devices);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,BuildingsID")] Devices devices)
        {
            if (id != devices.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevicesExists(devices.ID))
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
            return View(devices);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Devices
                .FirstOrDefaultAsync(m => m.ID == id);
            if (devices == null)
            {
                return NotFound();
            }

            return View(devices);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devices = await _context.Devices.FindAsync(id);
            _context.Devices.Remove(devices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevicesExists(int id)
        {
            return _context.Devices.Any(e => e.ID == id);
        }
    }
}
