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
    public class offerUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public offerUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: offerUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.offerUsers.ToListAsync());
        }

        // GET: offerUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerUser = await _context.offerUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offerUser == null)
            {
                return NotFound();
            }

            return View(offerUser);
        }

        // GET: offerUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: offerUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Notes")] offerUser offerUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(offerUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(offerUser);
        }

        // GET: offerUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerUser = await _context.offerUsers.FindAsync(id);
            if (offerUser == null)
            {
                return NotFound();
            }
            return View(offerUser);
        }

        // POST: offerUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Notes")] offerUser offerUser)
        {
            if (id != offerUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offerUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!offerUserExists(offerUser.Id))
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
            return View(offerUser);
        }

        // GET: offerUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerUser = await _context.offerUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offerUser == null)
            {
                return NotFound();
            }

            return View(offerUser);
        }

        // POST: offerUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offerUser = await _context.offerUsers.FindAsync(id);
            _context.offerUsers.Remove(offerUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool offerUserExists(int id)
        {
            return _context.offerUsers.Any(e => e.Id == id);
        }
    }
}
