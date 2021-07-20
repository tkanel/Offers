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
    public class ΟfferUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ΟfferUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ΟfferUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.OfferUsers.ToListAsync());
        }

        // GET: ΟfferUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var οfferUser = await _context.OfferUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (οfferUser == null)
            {
                return NotFound();
            }

            return View(οfferUser);
        }

        // GET: ΟfferUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ΟfferUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Notes")] ΟfferUser οfferUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(οfferUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(οfferUser);
        }

        // GET: ΟfferUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var οfferUser = await _context.OfferUsers.FindAsync(id);
            if (οfferUser == null)
            {
                return NotFound();
            }
            return View(οfferUser);
        }

        // POST: ΟfferUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Notes")] ΟfferUser οfferUser)
        {
            if (id != οfferUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(οfferUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ΟfferUserExists(οfferUser.Id))
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
            return View(οfferUser);
        }

        // GET: ΟfferUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var οfferUser = await _context.OfferUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (οfferUser == null)
            {
                return NotFound();
            }

            return View(οfferUser);
        }

        // POST: ΟfferUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var οfferUser = await _context.OfferUsers.FindAsync(id);
            _context.OfferUsers.Remove(οfferUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ΟfferUserExists(int id)
        {
            return _context.OfferUsers.Any(e => e.Id == id);
        }
    }
}
