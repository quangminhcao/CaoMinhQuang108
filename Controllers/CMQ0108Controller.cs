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
    public class CMQ0108Controller : Controller
    {
        private readonly NetCoreDbContext _context;

        public CMQ0108Controller(NetCoreDbContext context)
        {
            _context = context;
        }

        // GET: CMQ0108
        public async Task<IActionResult> Index()
        {
            return View(await _context.CMQ0108.ToListAsync());
        }

        // GET: CMQ0108/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMQ0108 = await _context.CMQ0108
                .FirstOrDefaultAsync(m => m.CMQId == id);
            if (cMQ0108 == null)
            {
                return NotFound();
            }

            return View(cMQ0108);
        }

        // GET: CMQ0108/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CMQ0108/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CMQId,CMQName,CMQGender")] CMQ0108 cMQ0108)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cMQ0108);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cMQ0108);
        }

        // GET: CMQ0108/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMQ0108 = await _context.CMQ0108.FindAsync(id);
            if (cMQ0108 == null)
            {
                return NotFound();
            }
            return View(cMQ0108);
        }

        // POST: CMQ0108/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CMQId,CMQName,CMQGender")] CMQ0108 cMQ0108)
        {
            if (id != cMQ0108.CMQId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cMQ0108);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CMQ0108Exists(cMQ0108.CMQId))
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
            return View(cMQ0108);
        }

        // GET: CMQ0108/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMQ0108 = await _context.CMQ0108
                .FirstOrDefaultAsync(m => m.CMQId == id);
            if (cMQ0108 == null)
            {
                return NotFound();
            }

            return View(cMQ0108);
        }

        // POST: CMQ0108/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cMQ0108 = await _context.CMQ0108.FindAsync(id);
            _context.CMQ0108.Remove(cMQ0108);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CMQ0108Exists(int id)
        {
            return _context.CMQ0108.Any(e => e.CMQId == id);
        }
    }
}
