using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Offers.Data;
using Offers.Models;

namespace Offers.Controllers
{
    public class DromologiaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DromologiaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dromologia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dromologia.ToListAsync());
        }

        // GET: Dromologia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dromologio = await _context.Dromologia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dromologio == null)
            {
                return NotFound();
            }

            return View(dromologio);
        }

        // GET: Dromologia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dromologia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Notes")] Dromologio dromologio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dromologio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dromologio);
        }

        // GET: Dromologia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dromologio = await _context.Dromologia.FindAsync(id);
            if (dromologio == null)
            {
                return NotFound();
            }
            return View(dromologio);
        }

        // POST: Dromologia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Notes")] Dromologio dromologio)
        {
            if (id != dromologio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dromologio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DromologioExists(dromologio.Id))
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
            return View(dromologio);
        }

        // GET: Dromologia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dromologio = await _context.Dromologia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dromologio == null)
            {
                return NotFound();
            }

            return View(dromologio);
        }

        // POST: Dromologia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dromologio = await _context.Dromologia.FindAsync(id);
            _context.Dromologia.Remove(dromologio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DromologioExists(int id)
        {
            return _context.Dromologia.Any(e => e.Id == id);
        }
    }
}
