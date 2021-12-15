using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaoMinhQuang108.Models;

namespace CaoMinhQuang108.Controllers
{
    public class StringProcessCMQ108Controller : Controller
    {
        private readonly NetCoreDbContext _context;

        public StringProcessCMQ108Controller(NetCoreDbContext context)
        {
            _context = context;
        }

        // GET: StringProcessCMQ108
        public async Task<IActionResult> Index()
        {
            return View(await _context.StringProcessCMQ108.ToListAsync());
        }

        // GET: StringProcessCMQ108/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stringProcessCMQ108 = await _context.StringProcessCMQ108
                .FirstOrDefaultAsync(m => m.CMQId == id);
            if (stringProcessCMQ108 == null)
            {
                return NotFound();
            }

            return View(stringProcessCMQ108);
        }

        // GET: StringProcessCMQ108/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StringProcessCMQ108/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Universisty,Address,PhoneNumber,CMQId,CMQName,CMQGender")] StringProcessCMQ108 stringProcessCMQ108)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stringProcessCMQ108);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stringProcessCMQ108);
        }

        // GET: StringProcessCMQ108/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stringProcessCMQ108 = await _context.StringProcessCMQ108.FindAsync(id);
            if (stringProcessCMQ108 == null)
            {
                return NotFound();
            }
            return View(stringProcessCMQ108);
        }

        // POST: StringProcessCMQ108/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Universisty,Address,PhoneNumber,CMQId,CMQName,CMQGender")] StringProcessCMQ108 stringProcessCMQ108)
        {
            if (id != stringProcessCMQ108.CMQId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stringProcessCMQ108);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StringProcessCMQ108Exists(stringProcessCMQ108.CMQId))
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
            return View(stringProcessCMQ108);
        }

        // GET: StringProcessCMQ108/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stringProcessCMQ108 = await _context.StringProcessCMQ108
                .FirstOrDefaultAsync(m => m.CMQId == id);
            if (stringProcessCMQ108 == null)
            {
                return NotFound();
            }

            return View(stringProcessCMQ108);
        }

        // POST: StringProcessCMQ108/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stringProcessCMQ108 = await _context.StringProcessCMQ108.FindAsync(id);
            _context.StringProcessCMQ108.Remove(stringProcessCMQ108);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StringProcessCMQ108Exists(int id)
        {
            return _context.StringProcessCMQ108.Any(e => e.CMQId == id);
        }
    }
}
