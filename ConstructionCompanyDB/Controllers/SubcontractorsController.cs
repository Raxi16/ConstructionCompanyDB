using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConstructionCompanyDB.Areas.Identity.Data;
using ConstructionCompanyDB.Models;
using Microsoft.AspNetCore.Authorization;

namespace ConstructionCompanyDB.Controllers
{
    public class SubcontractorsController : Controller
    {
        private readonly ConstructionCompanyDBContext _context;

        public SubcontractorsController(ConstructionCompanyDBContext context)
        {
            _context = context;
        }

        // GET: Subcontractors
        [Authorize]
        public async Task<IActionResult> Index()
        {
              return _context.Subcontractor != null ? 
                          View(await _context.Subcontractor.ToListAsync()) :
                          Problem("Entity set 'ConstructionCompanyDBContext.Subcontractor'  is null.");
        }

        // GET: Subcontractors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Subcontractor == null)
            {
                return NotFound();
            }

            var subcontractor = await _context.Subcontractor
                .FirstOrDefaultAsync(m => m.SubcontractorID == id);
            if (subcontractor == null)
            {
                return NotFound();
            }

            return View(subcontractor);
        }

        // GET: Subcontractors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subcontractors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubcontractorID,Name,JobName,Number,email")] Subcontractor subcontractor)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(subcontractor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subcontractor);
        }

        // GET: Subcontractors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Subcontractor == null)
            {
                return NotFound();
            }

            var subcontractor = await _context.Subcontractor.FindAsync(id);
            if (subcontractor == null)
            {
                return NotFound();
            }
            return View(subcontractor);
        }

        // POST: Subcontractors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubcontractorID,Name,JobName,Number,email")] Subcontractor subcontractor)
        {
            if (id != subcontractor.SubcontractorID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(subcontractor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubcontractorExists(subcontractor.SubcontractorID))
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
            return View(subcontractor);
        }

        // GET: Subcontractors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Subcontractor == null)
            {
                return NotFound();
            }

            var subcontractor = await _context.Subcontractor
                .FirstOrDefaultAsync(m => m.SubcontractorID == id);
            if (subcontractor == null)
            {
                return NotFound();
            }

            return View(subcontractor);
        }

        // POST: Subcontractors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Subcontractor == null)
            {
                return Problem("Entity set 'ConstructionCompanyDBContext.Subcontractor'  is null.");
            }
            var subcontractor = await _context.Subcontractor.FindAsync(id);
            if (subcontractor != null)
            {
                _context.Subcontractor.Remove(subcontractor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubcontractorExists(int id)
        {
          return (_context.Subcontractor?.Any(e => e.SubcontractorID == id)).GetValueOrDefault();
        }
    }
}
